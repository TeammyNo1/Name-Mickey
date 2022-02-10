namespace Name_Mickey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Open file event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create object form Open Filedialon Class
            OpenFileDialog openFileDialog = new OpenFileDialog();
             if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileparth = openFileDialog.FileName;
                string data = File.ReadAllText(fileparth);
                this.textBoxDisplayData.Text = data;
               
            }
            
            
            //File.ReadAllLines()
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //get text form textbox
            string  data = this.textBoxDisplayData.Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;
                //save to file 
                File.WriteAllText(filepath, data,System.Text.Encoding.UTF8);
            }

            
        }
    }
}