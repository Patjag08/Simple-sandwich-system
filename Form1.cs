namespace Subway
{
    public partial class Form1 : Form
    {
        //0 = £0 (Not selected)
        //1 = £1.65 (Six inch)
        //2 = £2.05 (Twelve inch)
        public int bread_type = 0;
        //Fillings
        public bool cheese = false;
        public bool turkey = false;
        public bool chicken = false;
        public bool bacon = false;
        public bool tuna = false;
        public bool steak = false;
        //take out
        public bool takeout = false;
        public Form1()
        {
            InitializeComponent();
        }
        public double calc_total()
        {
            double total_cost = 0;
            if (bread_type == 1)
            {
                total_cost = 1.65;
            }
            else if (bread_type == 2)
            {
                total_cost = 2.05;
            }
            else if (bread_type == 0)
            {
                total_cost = 0;
            }
            if (cheese) { total_cost += 0.95; }
            if (bacon) { total_cost += 1.10; }
            if (tuna) { total_cost += 0.95; }
            if (turkey) { total_cost += 1.35; }
            if (chicken) { total_cost += 1.40; }
            if (steak) { total_cost += 2.95; }
            //takeout calc
            if (takeout) { total_cost += total_cost * 0.05;}
            return total_cost;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Twelve inch
            six_check.Checked = !twelve_check.Checked;
            if (six_check.Checked == false && twelve_check.Checked == false ) { bread_type = 0; } else { bread_type = 2; }
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Six inch
            twelve_check.Checked = !six_check.Checked;
            if (six_check.Checked == false && twelve_check.Checked == false) { bread_type = 0; } else { bread_type = 1; }
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }
        private void Cheese_tomato_check_CheckedChanged(object sender, EventArgs e)
        {
            //Cheese and tomato filling
            cheese = Cheese_tomato_check.Checked;
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }

        private void Turkey_ham_check_CheckedChanged(object sender, EventArgs e)
        {
            //Turkey and ham filling
            turkey = Turkey_ham_check.Checked;
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }

        private void chicken_check_CheckedChanged(object sender, EventArgs e)
        {
            //Chicken terayaki filling
            chicken = chicken_check.Checked;
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }

        private void bacon_pepperoni_check_CheckedChanged(object sender, EventArgs e)
        {
            //Bacon and pepperoni filling
            bacon = bacon_pepperoni_check.Checked;
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }

        private void tuna_mayo_check_CheckedChanged(object sender, EventArgs e)
        {
            //Tuna and mayo filling
            tuna = tuna_mayo_check.Checked;
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }

        private void Steak_check_CheckedChanged(object sender, EventArgs e)
        {
            //Steak and cheese filling
            steak = Steak_check.Checked;
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }

        private void takeout_yes_CheckedChanged(object sender, EventArgs e)
        {
            //Yes for taking food out
            takeout = takeout_yes.Checked;
            Takeout_no.Checked = !takeout_yes.Checked;
            if (takeout_yes.Checked == false && Takeout_no.Checked == false) { eating_label.Text = "Eating in: N/A"; }
            else if (takeout_yes.Checked == true) { eating_label.Text = "Eating in: Yes"; }
            else { eating_label.Text = "Eating in: No"; }
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }

        private void Takeout_no_CheckedChanged(object sender, EventArgs e)
        {
            //No for taking food out
            takeout_yes.Checked = !Takeout_no.Checked;
            takeout = takeout_yes.Checked;
            if (takeout_yes.Checked == false && Takeout_no.Checked == false) { eating_label.Text = "Eating in: N/A"; }
            else if (takeout_yes.Checked == true) { eating_label.Text = "Eating in: Yes"; }
            else { eating_label.Text = "Eating in: No"; }
            total_label.Text = $"Price: £{calc_total().ToString("0.00")}";
        }
    }
}