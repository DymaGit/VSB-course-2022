using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LING;
using System.Text.Json;
namespace LING_UI {
    public partial class Form1 : Form {
        public static PeopleData[] People { get; set; }
        DataTable dt;
        public Form1() {
            InitializeComponent();
            var fileContent = File.ReadAllText("people.json");
            People = JsonSerializer.Deserialize<PeopleData[]>(fileContent);

            dt = new DataTable("People");
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Email");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Language");
            dt.Columns.Add("University");
            dt.Columns.Add("DateOfBirth", typeof(DateTime));
            dt.Columns.Add("Country");
            dt.Columns.Add("Company");
            dt.Columns.Add("JobTitle");


            foreach (PeopleData peopleData in People) {
                dt.Rows.Add(peopleData.id, peopleData.first_name, peopleData.last_name, peopleData.email, peopleData.gender, peopleData.language, peopleData.university, peopleData.date_of_birth, peopleData.country, peopleData.company, peopleData.job_title);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            dataGrid.DataSource = dt;
            comboBox1.Items.AddRange(ProgramLogic.GetLanguages(People));
        }

        private void button1_Click(object sender, EventArgs e) {
            List<PeopleData> peopleWithLastNamesContaining = ProgramLogic.LastNameContains(People, textBox1.Text);
            dt.Clear();
            PopulateTheTable(peopleWithLastNamesContaining);

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            List<PeopleData> peopleWithLastNamesContaining = ProgramLogic.LastNameContains(People, textBox1.Text);
            dt.Clear();
            PopulateTheTable(peopleWithLastNamesContaining);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

            List<PeopleData> peopleOfSpecialLanguage = ProgramLogic.GetPeopleOfSpecialLanguage(People, comboBox1.SelectedItem.ToString());
            dt.Clear();
            PopulateTheTable(peopleOfSpecialLanguage);

        }

        private void button2_Click(object sender, EventArgs e) {
            dt.Clear();
            textBox1.Text = "";
            comboBox1.Text = "";
            List<PeopleData> all = People.ToList();
            PopulateTheTable(all);
        }

        //METODA ze které berou všechny funkce výše.. vypíšou lidi podle vlastních parametrů(podle obsahujících písmenek, podle jazyka..)
        private void PopulateTheTable(List<PeopleData> ListChoice) {
            foreach (PeopleData peopleData in ListChoice) {
                dt.Rows.Add(peopleData.id, peopleData.first_name, peopleData.last_name, peopleData.email, peopleData.gender, peopleData.language, peopleData.university, peopleData.date_of_birth, peopleData.country, peopleData.company, peopleData.job_title);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            string exp = "";
            foreach (DataRow row in dt.Rows) {
                foreach (var cell in row.ItemArray) {
                    //System.Diagnostics.Debug.WriteLine(cell.ToString());
                    exp += $"{cell},";
                }
                exp += "\n";
            }
            System.Diagnostics.Debug.Write(exp);
            File.WriteAllText("export.txt", exp);
        }

        private void button4_Click(object sender, EventArgs e) {
            dt.Clear();
            PeopleData newOne = new PeopleData();
            newOne.id = People.Length + 1;  //People.Max(people => people.id) + 1;
            newOne.first_name = textBox2.Text;
            newOne.last_name = textBox3.Text;
            newOne.language = textBox4.Text;

            List<PeopleData> listPeople = People.ToList();
            listPeople.Add(newOne);
            People = listPeople.ToArray();
            PopulateTheTable(listPeople);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

            string jsonstring = JsonSerializer.Serialize(People);
            File.WriteAllText("peopleNew.json", jsonstring);


        }
    }
}
