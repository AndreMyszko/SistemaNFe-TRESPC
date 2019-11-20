using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcVLSM_Final.Model;

namespace CalcVLSM_Final
{
    public partial class ViewCalc : Form
    {
        AtributoIP classIP = new AtributoIP();

        AtributoHost classHost = new AtributoHost();
        List<AtributoHost> listHost = new List<AtributoHost>();

        ModelCalc modelCalc = new ModelCalc();

        public ViewCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //ViewCalc.Form
        {
            btnReiniciar.Enabled = false;
            nudHost.Enabled = false;
            btnAddHost.Enabled = false;
            btnCalcular.Enabled = false;
        }

        private void BtnAddIP_Click(object sender, EventArgs e)
        {
            Error_IP();
            //SetLimite_IP();

            btnAddIP.Enabled = false;
            btnReiniciar.Enabled = true;
            nudHost.Enabled = true;
            btnAddHost.Enabled = true;
            btnCalcular.Enabled = true;

        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            LimparDados();

            btnAddIP.Enabled = true;
            nudHost.Enabled = false;
            btnAddHost.Enabled = false;
            btnCalcular.Enabled = false;
        }

        private void BtnAddHost_Click(object sender, EventArgs e)
        {
            GetValor_Host();
            IncluirDGV();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            GetValor_IP();
            ConvertIP();
            //classIP._classe = modelCalc.DefinirClasse_IP(Convert.ToInt32(txtIP1.Text)); //model......

            ClasseIPBase();

            ConvertMascPad();
            BreakPoint();

            for (int i = 0; i < listHost.Count; i++)
            {
                int armazenarIP4 = classIP._ip4 = Acumulador_de_IP(classIP._ip4, classHost._total_hosts, classIP._totalPotencia);
                int armazenarBroadcast = Broadcast(armazenarIP4);
                rtbResultado.Text = rtbResultado.Text += ($"subnet{i+1}:\n{classIP._ip1}.{classIP._ip2}.{classIP._ip3}.{armazenarIP4}");
                MascaraCustomizada();
                rtbResultado.Text = rtbResultado.Text += ($"\nBroadcast:\n{classIP._ip1}.{classIP._ip2}.{classIP._ip3}.{armazenarBroadcast}\n\n");
            }

        }

        public void LimparDados()
        {
            txtIP1.Text = "";
            txtIP2.Text = "";
            txtIP3.Text = "";
            txtIP4.Text = "";
            rtbResultado.Text = "";
            dgvHost.DataSource = null;
            dgvHost.Rows.Clear(); 
            listHost.Clear();
        }

        public void GetValor_IP()
        {
            classIP._ip1 = Convert.ToInt32(txtIP1.Text);
            classIP._ip2 = Convert.ToInt32(txtIP2.Text);
            classIP._ip3 = Convert.ToInt32(txtIP3.Text);
            classIP._ip4 = Convert.ToInt32(txtIP4.Text);

            rtbResultado.Text += ($"IP Informado: {classIP._ip1}.{classIP._ip2}.{classIP._ip3}.{classIP._ip4}\n");
        }

        //public void DefMasc_Padrao()  DANGER DANGER
        //{
        //    if (classIP._classe == "A")
        //    {
        //        classIP._mascPad1 = 255;                   DANGER  ERROR ERROR
        //        classIP._mascPad2 = 0;
        //        classIP._mascPad3 = 0;
        //        classIP._mascPad4 = 0;
        //        rtbResultado.Text += ($"Máscara Padrão: {classIP._mascPad1}.{classIP._mascPad2}.{classIP._mascPad3}.{classIP._mascPad4}");
        //    }

        //    if (classIP._classe == "B")
        //    {                                                  DANGER ERROR
        //        classIP._mascPad1 = 255;
        //        classIP._mascPad2 = 255;
        //        classIP._mascPad3 = 0;
        //        classIP._mascPad4 = 0;
        //        rtbResultado.Text += ($"Máscara Padrão: {classIP._mascPad1}.{classIP._mascPad2}.{classIP._mascPad3}.{classIP._mascPad4}");
        //    }

        //    if (classIP._classe == "C")
        //    {
        //        classIP._mascPad1 = 255;
        //        classIP._mascPad2 = 255;                FATAL ERROR DANGER
        //        classIP._mascPad3 = 255;
        //        classIP._mascPad4 = 0;
        //        rtbResultado.Text += ($"Máscara Padrão: {classIP._mascPad1}.{classIP._mascPad2}.{classIP._mascPad3}.{classIP._mascPad4}");
        //    }
        //}

        public void Error_IP()
        {
            if (txtIP1.Text.Equals("") || txtIP2.Text.Equals("") || txtIP3.Text.Equals("") || txtIP4.Text.Equals(""))
            {
                MessageBox.Show("Não deixe nenhum dos campos do IP vazio!");
            }
        }

        public void SetLimite_IP()
        {
            if (classIP._ip1 > 255 || classIP._ip1 < 1 || classIP._ip2 > 255 || classIP._ip2 < 0 || classIP._ip3 > 255 || classIP._ip3 < 0 || classIP._ip4 > 254 || classIP._ip4 < 0)
            {
                MessageBox.Show("O valor informado para IP não está dentro do limite(255) permirido!");
                rtbResultado.Text = "--__Erro__--\n--__Erro__--\n--__Erro__--\n";
            }
        }

        public void BreakPoint()
        {
            rtbResultado.Text += "\n\n";
        }

        public int PotenciaHost(int hostPot)
        {
            int expoente = 0;
            int potencia = 0;

            while (hostPot > potencia)
            {
                potencia = Convert.ToInt32(Math.Pow(2, expoente));
                expoente++;
            }

            return potencia;
        }

        public void IncluirDGV()
        {
            dgvHost.DataSource = null;
            listHost = listHost.OrderByDescending(x => x._host).ToList();
            dgvHost.DataSource = listHost;
        }

        public void GetValor_Host()
        {
            classHost = new AtributoHost();
            classHost._host = Convert.ToInt32(nudHost.Value);
            classHost._host_mais_2 = Convert.ToInt32(nudHost.Value + 2);
            classHost._total_hosts = PotenciaHost(classHost._host_mais_2);
            classIP._totalPotencia = ValorPotencia(classHost._total_hosts);
            listHost.Add(classHost);
        }

        public double ValorPotencia(double potencia)
        {
            double acumulador = 0;
            acumulador += potencia;

            return acumulador;
        }

        public int Acumulador_de_IP(int IP4, int TotalHost, double verificador)
        {
            int valorAcumulado = 0;
            if (verificador <= 255)
            {
                
                valorAcumulado = IP4 + TotalHost;
            }
            return valorAcumulado;
        }

        public int Broadcast(int IP4)
        {
            int broadcast = IP4 -1;
            return broadcast;
        }

        public string ConvertToBin(int n)
        {
            string numBinario = string.Empty;
            double resto;

            while (n > 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    resto = n % 2;
                    n /= 2;

                    if (numBinario.Length < 7)
                    {
                        numBinario = resto + numBinario;
                    }
                }
            }
            return numBinario;
        }

        public void ConvertIP()
        {
            string IP_bin1 = (ConvertToBin(classIP._ip1));
            string IP_bin2 = (ConvertToBin(classIP._ip2));
            string IP_bin3 = (ConvertToBin(classIP._ip3));
            string IP_bin4 = (ConvertToBin(classIP._ip4));

            rtbResultado.Text += ($"IP Informado: {IP_bin1}.{IP_bin2}.{IP_bin3}.{IP_bin4}");
        }

        public void ConvertMascPad()
        {
            string mascPad_bin1 = (ConvertToBin(classIP._mascPad1));
            string mascPad_bin2 = (ConvertToBin(classIP._mascPad2));
            string mascPad_bin3 = (ConvertToBin(classIP._mascPad3));
            string mascPad_bin4 = (ConvertToBin(classIP._mascPad4));

            rtbResultado.Text += ($"Mascara Padrão: {mascPad_bin1}.{mascPad_bin2}.{mascPad_bin3}.{mascPad_bin4}");
        }

        public void ConvertMascCust()
        {
            string mascCust_bin1 = (ConvertToBin(classIP._mascCust1));
            string mascCust_bin2 = (ConvertToBin(classIP._mascCust2));
            string mascCust_bin3 = (ConvertToBin(classIP._mascCust3));
            string mascCust_bin4 = (ConvertToBin(classIP._mascCust4));

            rtbResultado.Text += ($"Máscara Customizada: {mascCust_bin1}.{mascCust_bin2}.{mascCust_bin3}.{mascCust_bin4}");
        }

        public void ConvertHost()
        {
            int hostBin = Convert.ToInt32(ConvertToBin(classHost._host));

            rtbResultado.Text += ($"Host Binário: {hostBin}");
        }

        public void MascaraCustomizada()
        {
            if (classIP._ip1 >= 0 && classIP._ip1 <= 127)
            {
                rtbResultado.Text += $"\nMáscara Customizada:\n{255}.{255}.{255}.{256 - classHost._total_hosts}";
            }

            if (classIP._ip1 >= 128 && classIP._ip1 <= 191)
            {
                rtbResultado.Text += $"\nMáscara Customizada:\n{255}.{255}.{256 - classHost._total_hosts}.{0}";
            }

            if (classIP._ip1 >= 192 && classIP._ip1 <= 224)
            {
                rtbResultado.Text += $"\nMáscara Customizada:\n{255}.{256 - classHost._total_hosts}.{0}.{0}";
            }
        }

        public void ClasseIPBase()
        {
            if (classIP._ip1 >= 0 && classIP._ip1 <= 127)
            {
                rtbResultado.Text += ($"\nClasse:\nC\n");
                rtbResultado.Text += ($"\nIP Base:\n{classIP._ip1}.{classIP._ip2}.{classIP._ip3}.{0}\n");
                rtbResultado.Text += ($"\nMascara Padrão:\n{255}.{255}.{255}.{0}\n");
            }

            if (classIP._ip1 >= 128 && classIP._ip1 <= 191)
            {
                rtbResultado.Text += ($"\nClasse:\nB\n");
                rtbResultado.Text += ($"\nIP Base:\n{classIP._ip1}.{classIP._ip2}.{0}.{0}\n");
                rtbResultado.Text += ($"\nMascara Padrão:\n{255}.{255}.{0}.{0}\n");
            }

            if (classIP._ip1 >= 192 && classIP._ip1 <= 224)
            {
                rtbResultado.Text += ($"\nClasse:\nA\n");
                rtbResultado.Text += ($"\nIP Base:\n{classIP._ip1}.{0}.{0}.{0}\n");
                rtbResultado.Text += ($"\nMascara Padrão:\n{255}.{0}.{0}.{0}\n");
            }
        }
    }
}
