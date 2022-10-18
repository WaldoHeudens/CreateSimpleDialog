namespace Les_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btStartLoop_Click(object sender, EventArgs e)
        {
            bool stop = false;
            bool go = false;

            for (int i = 0; i < 10; i++)
            {
                // gebruiker moet optie krijgen om  
                // - de loop te onderbreken
                // - de loop stap voor stap te doorlopen
                // - de loop ineens helemaal af te werken

                if (!go)
                {
                    //LoopDialog loopDialog = new LoopDialog();
                    //loopDialog.ShowDialog();
                    //switch (loopDialog.DialogResult)
                    switch((new LoopDialog()).ShowDialog())
                    {
                        case DialogResult.OK:
                            go = true;
                            break;
                        case DialogResult.Cancel:
                            stop = true;
                            break;
                        case DialogResult.Continue:
                            break;
                    }
                    if (stop) break;
                }
                label1.Text = "We lopen door de loop: " + i;

            }

        }
    }
}