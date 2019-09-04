using CanRackSpace;
using CanSpace;
using CoinBoxSpace;
using CoinSpace;
using FlavorSpace;
using PurchasePriceSpace;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using FoodLockerSpace;



namespace FormSpace
{
    public partial class Form1 : Form
    {
        readonly CoinBox coinBox = new CoinBox();

        readonly CanRack canRack = new CanRack();

        readonly PurchasePrice soda;

        private string inputResponse;

        private Can can;

        readonly ListViewItem regularListView = new ListViewItem(Flavor.REGULAR.ToString());

        readonly ListViewItem orangeListView = new ListViewItem(Flavor.ORANGE.ToString());

        readonly ListViewItem lemonListView = new ListViewItem(Flavor.LEMON.ToString());

        readonly ListViewItem nickelListView = new ListViewItem(Coin.Denomination.NICKEL.ToString());

        readonly ListViewItem dimeListView = new ListViewItem(Coin.Denomination.DIME.ToString());

        readonly ListViewItem quarterListView = new ListViewItem(Coin.Denomination.QUARTER.ToString());

        readonly ListViewItem halfdollarListView = new ListViewItem(Coin.Denomination.HALFDOLLAR.ToString());

        readonly ListViewItem totaldollarListView = new ListViewItem();

        readonly FoodLocker food = new FoodLocker();

        

        //Apple apple = new Apple("Washington red", price, DateTime.Now);

        //Banana banana = new Banana(DateTime.Now, "Georges favorite!", new PurchasePrice(99));
        //CandyBar candy = new CandyBar(56, "Fatty bar", new PurchasePrice(25));
        //PotatoChips potatoChips = new PotatoChips(99, "Lazzzz", new PurchasePrice(87));

        public Form1()
        {
            InitializeComponent();

            canRack.FillTheCanRack();

            decimal price = .75m;

            soda = new PurchasePrice(price);

            InstructionLabel.Text = string.Format($"To purchse Soda\nplease insert {soda.PriceDecimal:c2}");

            totalAmountLabel.Text = string.Format($"{coinBox.ValueOf():c2}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            regularListView.SubItems.Add(canRack.DisplayCanRack(Flavor.REGULAR).ToString());

            orangeListView.SubItems.Add(canRack.DisplayCanRack(Flavor.ORANGE).ToString());

            lemonListView.SubItems.Add(canRack.DisplayCanRack(Flavor.LEMON).ToString());


            listViewFlavorCapacity.Items.Add(regularListView); //0

            listViewFlavorCapacity.Items.Add(orangeListView); //1

            listViewFlavorCapacity.Items.Add(lemonListView); //2    


            nickelListView.SubItems.Add(coinBox.NickelCount.ToString());

            nickelListView.SubItems.Add(((int)Coin.Denomination.NICKEL/100m).ToString());

            dimeListView.SubItems.Add(coinBox.DimeCount.ToString());

            dimeListView.SubItems.Add(((int)Coin.Denomination.DIME/100m).ToString());

            quarterListView.SubItems.Add(coinBox.QuarterCount.ToString());

            quarterListView.SubItems.Add(((int)Coin.Denomination.QUARTER/100m).ToString());

            halfdollarListView.SubItems.Add(coinBox.HalfDollarCount.ToString());

            halfdollarListView.SubItems.Add(((int)Coin.Denomination.HALFDOLLAR/100m).ToString());


            listViewCoinCount.Items.Add(nickelListView); //0

            listViewCoinCount.Items.Add(dimeListView); //1

            listViewCoinCount.Items.Add(quarterListView); //2

            listViewCoinCount.Items.Add(halfdollarListView); //3

            totaldollarListView.SubItems.Add("");

            totaldollarListView.SubItems.Add(coinBox.ValueOf().ToString());

            listViewCoinCount.Items.Insert(4, totaldollarListView);

        }

        //denomination select section
        private void ButtonNickel_Click(object sender, EventArgs e)
        {
            DepositMoney(Coin.Denomination.NICKEL);
        }

        private void ButtonDime_Click(object sender, EventArgs e)
        {
            DepositMoney(Coin.Denomination.DIME);

        }

        private void ButtonQuarter_Click(object sender, EventArgs e)
        {
            DepositMoney(Coin.Denomination.QUARTER);
        }

        private void ButtonHalfdollar_Click(object sender, EventArgs e)
        {          
            DepositMoney(Coin.Denomination.HALFDOLLAR);
        }

        private void DepositMoney(Coin.Denomination denomination)
        {
            coinBox.Deposit(new Coin(denomination));
            InstructionLabel.Text = string.Format($"To purchse Soda\nplease insert {soda.PriceDecimal:c2}");
            totalAmountLabel.Text = string.Format($"{coinBox.ValueOf():c2}");
        }

        //change dispenser 
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            inputResponse = string.Format($"Removing {coinBox.ValueOf():c2}");
            InstructionLabel.Text = inputResponse;
            coinBox.Withdraw(coinBox.ValueOf());
            totalAmountLabel.Text = string.Format($"{coinBox.ValueOf():c2}");
        }

        //flavor select section
        private void ButtonRegular_Click(object sender, EventArgs e)
        {            
            SelectSoda(Flavor.REGULAR);
        }

        private void ButtonOrange_Click(object sender, EventArgs e)
        {           
            SelectSoda(Flavor.ORANGE);
        }

        private void ButtonLemon_Click(object sender, EventArgs e)
        {
            SelectSoda(Flavor.LEMON);
        }

        private void SelectSoda(Flavor SodaFlavor)
        {
            if (coinBox.ValueOf() < soda.PriceDecimal)
            {
                inputResponse = string.Format($"{coinBox.ValueOf():c} is less than {soda.PriceDecimal:c2},\nplease add more money.");
                InstructionLabel.Text = inputResponse;
            }
            else
            {
                if (!canRack.IsEmpty(SodaFlavor))
                {
                    if (coinBox.Withdraw(soda.PriceDecimal))
                    {
                        try
                        {
                            can = new Can(FlavorOps.ToFlavor(SodaFlavor.ToString()));
                            canRack.RemoveACanOf(can.TheFlavor);
                            Debug.Write($"Result {SodaFlavor}");
                            inputResponse = string.Format($"One {SodaFlavor} can of soda on the way!");
                            InstructionLabel.Text = inputResponse;
                            totalAmountLabel.Text = string.Format($"{coinBox.ValueOf():c2}");
                        }
                        catch (Exception exc)
                        {
                            inputResponse = string.Format($"Incorrect entry, please try again.");
                            MessageBox.Show(inputResponse);
                            Debug.WriteLine($"Exception {exc.Message}");
                        }
                    }
                    else
                    {
                        inputResponse = string.Format($"Please use exact change!");
                        InstructionLabel.Text = inputResponse;
                        totalAmountLabel.Text = string.Format($"{coinBox.ValueOf():c2}");
                    }
                }
                else
                {
                    inputResponse = string.Format($"{SodaFlavor} is empty!");
                    InstructionLabel.Text = inputResponse;
                    totalAmountLabel.Text = string.Format($"{coinBox.ValueOf():c2}");
                }
            }
        }

        private void ButtonRefillRack_Click(object sender, EventArgs e)
        {
            canRack.FillTheCanRack();

            regularListView.SubItems[1].Text = canRack.DisplayCanRack(Flavor.REGULAR).ToString();

            orangeListView.SubItems[1].Text = canRack.DisplayCanRack(Flavor.ORANGE).ToString();

            lemonListView.SubItems[1].Text = canRack.DisplayCanRack(Flavor.LEMON).ToString();
        }

        private void ButtonEmptyCoinBox_Click(object sender, EventArgs e)
        {
            coinBox.Withdraw(coinBox.ValueOf());

            nickelListView.SubItems[1].Text = coinBox.NickelCount.ToString();

            dimeListView.SubItems[1].Text = coinBox.DimeCount.ToString();

            quarterListView.SubItems[1].Text = coinBox.QuarterCount.ToString();

            halfdollarListView.SubItems[1].Text = coinBox.HalfDollarCount.ToString();

            totaldollarListView.SubItems[2].Text = coinBox.ValueOf().ToString();
        }

        private void MainTabControl_Selected(object sender, TabControlEventArgs e)
        {
            regularListView.SubItems[1].Text = canRack.DisplayCanRack(Flavor.REGULAR).ToString();

            orangeListView.SubItems[1].Text = canRack.DisplayCanRack(Flavor.ORANGE).ToString();

            lemonListView.SubItems[1].Text = canRack.DisplayCanRack(Flavor.LEMON).ToString();

            nickelListView.SubItems[1].Text = coinBox.NickelCount.ToString();

            dimeListView.SubItems[1].Text = coinBox.DimeCount.ToString();

            quarterListView.SubItems[1].Text = coinBox.QuarterCount.ToString();

            halfdollarListView.SubItems[1].Text = coinBox.HalfDollarCount.ToString();

            totaldollarListView.SubItems[2].Text = coinBox.ValueOf().ToString();
        }

        private void ButtonServiceNotes_Click(object sender, EventArgs e)
        {
            //bring up a form to allow creating service notes, text notes
            //mdi form, IsMDIContainer to true
            //not a service note

            Form2 form2 = new Form2();

            //form2.IsMdiContainer = true;
            form2.Show();

            //Debug.WriteLine();

        }

        private void ButtonStockSnacks_Click(object sender, EventArgs e)
        {
            food.Stock();
            
            foreach (var item in food.Store)
            {
                listBoxSnacks.Items.Add(item.ToString());               
            }     

            Debug.WriteLine("Foodlocker stocked!");
        }

        private void ListBoxSnacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = listBoxSnacks.SelectedItem;

            MessageBox.Show(x.ToString());

            //if (x == )

        }
    }
}
