using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Globalization;

namespace SP_500
{
    public partial class Form1 : Form
    {
        public static String[,] array = {{"-0,8","-2,73","1,71","3,23","-5,49","-4,73","-0,82","0,36","0,8","0,46","-5,53","-0,85"},
            {"-3,71","1,48","-3,51","-11,43","-0,78","0,01","3,26","5,78","1,97","-0,3","6,62","4,11"},
            {"3,89","2,57","3,42","-1,6","-2,32","-0,71","-1,76","2,49","-2,1","-4,37","6,64","4,42"},
            {"1,59","2,37","1,02","-1,01","0,28","-0,98","3,54","-1,45","-0,06","5,01","2,07","0,75"},
            {"-4","-2,26","-2,31","-3,23","-2,65","0,98","-3,38","1,77","3,32","-7,46","-7,41","0,83"},
            {"-3,71","3,26","-5,21","-3,91","-0,36","-12,06","-4,92","-11,08","1,38","2,94","-6,82","8,22"},
            {"9,97","4,58","1,11","6,11","2,13","-0,68","-7,17","-1,4","4,4","1,3","-1,54","9,35"},
            {"3,81","0,62","0,74","-1,09","0,37","2,13","-1,08","2,09","-3,61","-0,53","3,44","-1,04"},
            {"-3,36","-0,72","-2,01","-0,43","0,24","0,79","-2,4","-1,49","-2,51","0,5","-0,4","-4,01"},
            {"-1,6","-0,52","4,01","4,53","-0,4","-0,82","6,84","-0,35","-3,64","-5,86","1,47","3,27"},
            {"-2,2","1,32","1,27","-3,12","1,29","0,32","4,02","0,46","-4,12","-1,24","3,32","1,86"},
            {"2,94","-10,14","-2,26","4,01","5,7","4,97","2,76","1,98","2,35","3,76","-2,16","-0,79"},
            {"-4,06","3,44","0,61","-2,38","-0,03","-3,08","0,04","-9,19","1,51","2,72","0,86","-5,11"},
            {"-2,22","-2,64","5,03","-0,37","-6,44","-0,27","0,59","11,87","8,55","4,71","1,77","3,71"},
            {"2,03","3,87","3,46","3,79","1,45","0,31","-2,7","2,8","0,35","-1,34","-0,23","0,98"},
            {"-5,57","0,25","0,02","-0,54","-2,13","-1,29","8,79","0,93","-0,69","1,29","-0,71","4,5"},
            {"5,29","-0,85","0,55","2,35","2,23","2,06","-2,03","-2,16","1,12","6,13","5,01","0,48"},
            {"5,99","6,67","2,93","0,22","2,57","-1,8","2,1","-2,9","-0,18","3,44","1,62","6"},
            {"6,08","3,91","-1,38","-0,18","4,13","2,85","5,9","-3,54","-12,08","-12,38","-1,33","3,98"},
            {"3,06","2,79","-1,39","-2,52","5,55","-0,73","-2,13","1,25","3,46","-2,1","2,16","3"},
            {"2,88","-0,73","2,89","3,53","3,15","2,55","4,53","0,14","-0,19","-2,04","2,58","-3,21"},
            {"-2,98","2,15","0,04","3,61","2,62","-0,21","-8,7","-5,13","-2,9","2,76","4,59","-1,28"},
            {"11,44","2,89","2,11","-0,47","0,05","0,63","2,38","-0,74","0,04","-0,28","0,86","7,2"},
            {"-0,96","-1,51","0,12","1,92","-1,68","1,7","0,66","0,09","-1,53","2,61","3,34","-0,35"},
            {"1,37","1,8","-1,62","0,59","0,73","0,06","1,48","1,15","0,83","-0,06","0,89","1,46"},
            {"-0,42","-1,76","-3,48","0,99","0,77","-0,79","2,67","0,55","-0,51","-0,5","-1,02","2,04"},
            {"3,41","2,22","2,88","3,15","2,98","3,55","0,25","3,52","0,59","2,43","3,46","-0,42"},
            {"5,56","-0,71","-0,19","2,16","1,22","-3,66","2,88","1,7","3,79","4,85","1,2","2,93"},
            {"4,04","-0,87","-3,53","9,29","5,21","5,61","0,16","0,94","1,39","-1,09","2,76","0,05"},
            {"6,21","5,12","3,22","-0,41","-0,01","4,34","-7,08","-5,01","1,04","10,98","4,17","4,79"},
            {"-0,19","2,61","3,5","-0,1","-0,61","4,21","-4,01","-1,07","-1,45","7,04","2,81","-0,42"},
            {"-3,05","3,09","1,37","-2,95","2,63","0,62","0,94","-1,59","-5,38","-0,83","-3,27","-0,18"},
            {"-2,53","-9,29","0,05","6,4","-2,55","-2,39","-2,05","-11,65","3,53","5,23","1,87","-0,52"},
            {"-3,73","4,36","-4,05","-2,82","-5,97","-10,86","0,8","-4,92","-1,53","6,63","-0,82","-0,66"},
            {"-7,13","0,7","5,52","5,48","5,59","0,49","-0,54","2,83","2,14","1,49","3,18","4,43"},
            {"0,55","-2,19","0,65","-3,13","2,53","-2,08","-1,44","2,57","-0,42","4,72","3,11","-1,55"},
            {"1,1","-1,03","-3,06","1,44","2,13","1,34","-0,2","-0,93","-2,82","4,81","2,56","0,7"},
            {"-0,22","0,93","-0,05","-1,28","-2,9","0,43","2,09","3,04","4,18","2,16","2","0,39"},
            {"1,06","-3,35","3,51","2,77","0,15","0,6","-4,02","2,79","2,77","-5,37","1,31","-7,1"},
            {"-1,85","-3,46","3,62","1,71","-5,2","-6,57","2,52","-4,72","-19,38","-6,82","0,69","-1,53"},
            {"-7,17","-5,92","12,04","6,35","1,99","1,43","7,87","3,58","2,3","2,02","2,4","1,01"},
            {"-2,92","5,51","3,91","-5,96","-3,45","-0,18","0,73","3,31","4,45","2,45","3,54","2,97"},
            {"2,65","-2,07","1,57","0,19","-3,56","3,01","-10,65","-0,94","3,24","1,86","1,81","4,33"},
            {"3,71","2,11","-0,34","-2,98","-1,01","3,09","2,82","2,57","-0,18","-2,37","2,46","3,96"},
            {"1,5","2,46","1,56","4,39","-1,35","3,22","0,13","1,08","2,38","4,07","1,53","0,6"},
            {"-0,5","2,07","-0,13","1,18","3,01","1,54","-0,26","1,7","-2,4","6,28","1,21","-0,64"},
            {"2,39","-0,54","0,68","0,47","-0,78","-0,09","-2,29","-4,36","4,37","3,15","-0,76","-6,57"},
            {"-0,63","5,91","2,35","-0,71","0,74","3,47","1,11","-0,68","-0,63","1,36","3,91","0,85"},
            {"2,26","1,67","-0,45","1,61","1,69","1,06","-0,05","1,12","2,8","1,59","2,95","3,72"},
            {"-3,03","0,13","-1,88","1,75","1,98","1,41","2,22","1,62","-4,32","-1,47","-1,02",""}};

        public static int endingYear = 2018;
        public static int startingYear = endingYear - (array.GetLength(0) - 1);

        public static int numberOfMonths = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            //SETUP YEARS
            for (int i = startingYear; i <= endingYear; i++) {
                yearComboBox.Items.Add(i);
                endYearComboBox.Items.Add(i);
            }
        }

        private static void setup() {
            String text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\percent.txt").Replace("%", "").Replace(".", ",");
            Double[] array = Array.ConvertAll(text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries), Double.Parse);

            String result = "\t\tpublic static String[,] array = {";
            int counter = Int32.Parse(Math.Ceiling((Double.Parse(array.Length.ToString()) / 12.0)).ToString());
            for (int i = 0; i < counter; i++) {
                result += "{";
                for (int b = 0; b < 12; b++) {
                    result += "\"";
                    result += ((i * 12) + b >= array.Length ? "" : array[(i * 12) + b].ToString());
                    result += "\"" + (b == 11 ? "" : ",");
                }
                result += i == counter - 1 ? "}" : "},\n\t\t\t";
            }
            result += "};";
            Debug.WriteLine(result);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Double percentage = getPercent();
            Double annualPercentage = getAnnualPercent();

            overallTextBox.Text = floorNumber(numToPercent(percentage), 3).ToString() + "%";
            annualTextBox.Text = floorNumber(numToPercent(annualPercentage), 3) + "%";
            averageTextBox.Text = floorNumber(numToPercent(Math.Pow(percentage, 1.0 / numberOfMonths)), 3).ToString() + "%";
        }

        private Double getAnnualPercent() {
            int firstIndex = yearComboBox.SelectedIndex;
            Double annualPercentage = 1.0;
            for (int i = 0; i < Int32.Parse(endYearComboBox.Text) - Int32.Parse(yearComboBox.Text) + 1; i++)
            {
                for (int b = 0; b < 12; b++)
                {
                    if (!string.IsNullOrEmpty(array[firstIndex, b])) {
                        annualPercentage *= percentToNum(Double.Parse(array[firstIndex, b]));
                    }
                }
                firstIndex++;
            }
            return Math.Pow(annualPercentage, 1.0 / (Int32.Parse(endYearComboBox.Text) - Int32.Parse(yearComboBox.Text) + 1));
        }

        private Double getPercent() {
            int selectedYear = Int32.Parse(yearComboBox.Text);
            int selectedMonth = monthComboBox.SelectedIndex; ;

            int selectedEndYear = Int32.Parse(endYearComboBox.Text);
            int selectedEndMonth = endMonthComboBox.SelectedIndex;

            //GET NUMBER OF MONTHS
            DateTime start = new DateTime(selectedYear, selectedMonth + 1, 1);
            DateTime end = new DateTime(selectedEndYear, selectedEndMonth + 1, 1);
            numberOfMonths = 1 + ((end.Year - start.Year) * 12) + end.Month - start.Month;

            int firstIndex = yearComboBox.SelectedIndex;
            int secondIndex = monthComboBox.SelectedIndex;

            Double percentage = 1.0;

            for (int i = 0; i < numberOfMonths; i++)
            {
                percentage *= percentToNum(Double.Parse(array[firstIndex, secondIndex]));

                secondIndex++;
                if (secondIndex == 12)
                {
                    secondIndex = 0;
                    firstIndex++;
                }
            }

            return percentage;
        }

        private Double floorNumber(Double number, int decimalPlaces) {
            return Math.Floor(number * Math.Pow(10, decimalPlaces)) / Math.Pow(10, decimalPlaces);
        }

        private Double numToPercent(Double number) {
            return (number - 1) * 100;
        }

        private Double percentToNum(Double percent)
        {
            return (percent / 100) + 1;
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] arrayMonths = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            monthComboBox.Items.Clear();
            for (int i = 0; i < 12; i++) {
                if (!string.IsNullOrEmpty(array[yearComboBox.SelectedIndex, i])) {
                    monthComboBox.Items.Add(new DateTime(2015, i + 1, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("us")));
                }
            }
        }

        private void endYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] arrayMonths = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            endMonthComboBox.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                if (!string.IsNullOrEmpty(array[endYearComboBox.SelectedIndex, i]))
                {
                    endMonthComboBox.Items.Add(new DateTime(2015, i + 1, 1).ToString("MMMM", CultureInfo.CreateSpecificCulture("us")));
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(monthComboBox.Text) && !string.IsNullOrEmpty(yearComboBox.Text) && !string.IsNullOrEmpty(endMonthComboBox.Text) && !string.IsNullOrEmpty(endYearComboBox.Text)) {
                calculateButton.Enabled = true;
            }
            else {
                calculateButton.Enabled = false;
            }
        }
    }
}
