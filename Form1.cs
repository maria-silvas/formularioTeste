namespace formularioTeste
{
    public partial class Form1 : Form
    {   
        Button btnOla;
        private Form novaJanela;
        private Form janelaOla;
        Label lblOla;
        TextBox txbOla;
        Button btnClose;

        public Form1()
        {
            this.BackColor = System.Drawing.Color.LightGray;
            this.Text = "Sistema de Ola";
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new Size(600, this.Height);
            this.MaximumSize = new Size(600, this.Height);
            this.MaximumSize = new Size(350, this.Width);
            this.MinimumSize = new Size(350, this.Width);

            this.txbOla = new TextBox();
            txbOla.Location = new Point(125, 52);
            Controls.Add(txbOla);

            this.lblOla = new Label();
            this.lblOla.Text = "Seu Nome";
            lblOla.Location = new Point(150, 30);
            Controls.Add(lblOla);
        
            this.btnOla = new Button();
            this.btnOla.Text = "Olá";
            btnOla.Location = new Point(95, 140);
            Controls.Add(btnOla);
            btnOla.Click += new EventHandler(BtnOla_Click);

            this.btnClose = new Button();
            this.btnClose.Text = "Close";
            this.btnClose.Location = new Point(200, 140);
            Controls.Add(btnClose);
            btnClose.Click += new EventHandler(BtnClose_Click);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOla_Click(object sender, EventArgs e)
        {
            janelaOla = new Form();
            janelaOla.Text = "Ola";
            janelaOla.Show();

            // Adiciona um novo Label com a mensagem "Olá {nome}"
            Label lblMensagem = new Label();
            lblMensagem.Text = "Olá " + txbOla.Text;
            lblMensagem.Location = new Point(100, 50);
            janelaOla.Controls.Add(lblMensagem);
        }

     
    }
}
