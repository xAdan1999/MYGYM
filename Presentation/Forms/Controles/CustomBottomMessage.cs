using System.Windows.Forms;

namespace Presentation.Forms.Controles
{
    public partial class CustomBottomMessage : UserControl
    {
        public string message 
        {
            get { return lb_message.Text; }
            set { lb_message.Text = value; }
        }

        byte contador = 0;

        public CustomBottomMessage()
        {
            InitializeComponent();
        }

        private void BottomMessage_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if(contador != 3)
            {
                contador++;
            }
            else
            {
                this.Dispose();
            }
        }
    }
}
