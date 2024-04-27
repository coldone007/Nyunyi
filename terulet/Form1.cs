using System;
using System.Windows.Forms;

namespace terulet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Program elején elrejtem a mezőket
            VisibleX(false);
            VisibleY(false);
            VisibleZ(false);
        }

        double terulet;
        double kerulet;
        double liter;

        // X adatok láthatósága
        void VisibleX(bool b)
        {
            if (b == true)
            {
                LBLoldalX.Visible = true;
                oldalX.Visible = true;
                oldalX.Text = string.Empty;
            }
            else
            {
                LBLoldalX.Visible = false;
                oldalX.Visible = false;
                oldalX.Text = string.Empty;
            }
        }
        // Y adatok láthatósága
        void VisibleY(bool b)
        {
            if (b == true)
            {
                LBLoldalY.Visible = true;
                oldalY.Visible = true;
                oldalY.Text = string.Empty;
            }
            else
            {
                LBLoldalY.Visible = false;
                oldalY.Visible = false;
                oldalY.Text = string.Empty;
            }
        }
        // Z adatok láthatósága
        void VisibleZ(bool b)
        {
            if (b == true)
            {
                LBLoldalZ.Visible = true;
                oldalZ.Visible = true;
                oldalZ.Text = string.Empty;
            }
            else
            {
                LBLoldalZ.Visible = false;
                oldalZ.Visible = false;
                oldalZ.Text = string.Empty;
            }
        }

        private void shapeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (shapeList.SelectedIndex)
            {
                case 0:
                    // Négyzet
                    VisibleX(true);
                    VisibleY(true);
                    VisibleZ(false);

                    LBLoldalX.Text = "A oldala:";
                    LBLoldalY.Text = "B oldala:";
                    litermasol.Enabled = false;
                    break;

                case 1:
                    // Kör
                    VisibleX(true);
                    VisibleY(false);
                    VisibleZ(false);

                    LBLoldalX.Text = "Kör sugara:";
                    litermasol.Enabled = false;
                    break;
                case 2:
                    // Kocka
                    VisibleX(true);
                    VisibleY(false);
                    VisibleZ(false);

                    pictureBoxElolnezet.Image = global::terulet.Properties.Resources.kocka;

                    LBLoldalX.Text = "A él:";
                    litermasol.Enabled = false;
                    break;
                case 3:
                    // Téglatest
                    VisibleX(true);
                    VisibleY(true);
                    VisibleZ(true);

                    pictureBoxElolnezet.Image = global::terulet.Properties.Resources.téglatest;

                    LBLoldalX.Text = "A él:";
                    LBLoldalY.Text = "B él:";
                    LBLoldalZ.Text = "C él:";
                    litermasol.Enabled = false;
                    break;
                case 4:
                    // Henger
                    VisibleX(true);
                    VisibleY(true);
                    VisibleZ(false);

                    pictureBoxElolnezet.Image = global::terulet.Properties.Resources.henger;

                    LBLoldalX.Text = "Sugár:";
                    LBLoldalY.Text = "Magasság:";
                    litermasol.Enabled = false;
                    break;
                case 5:
                    // Gömb
                    VisibleX(true);
                    VisibleY(false);
                    VisibleZ(false);

                    pictureBoxElolnezet.Image = global::terulet.Properties.Resources.gömb;

                    LBLoldalX.Text = "Sugár:";
                    litermasol.Enabled = false;
                    break;
            }
        }
        // Liter számitás
        double literValtas(double t)
        {
            switch (unitList.SelectedIndex)
            {
                case 0:
                    return t * 1000;
                case 1:
                    return t * 0.001;
                case 2:
                    return t * 0.000001;
                default:
                    return 0;
            }
        }

        static bool InputCheck(string input)
        {
            double output;

            if (string.IsNullOrEmpty(input))
            {
                throw new Exception("string");
            }

            return double.TryParse(input, out output);
        }

        private void szamit_Click(object sender, EventArgs e)
        {
            double x;
            double y;
            double z;

            try
            {
                double.TryParse(oldalX.Text, out x);
                double.TryParse(oldalY.Text, out y);
                double.TryParse(oldalZ.Text, out z);

                var unit = unitList.SelectedItem;
                var index = elozmenyek.Items.Count;

                if (shapeList.SelectedItem == null)
                {
                    throw new Exception("shape");
                }

                if (unitList.SelectedItem == null)
                {
                    throw new Exception("unit");
                }
                else
                {
                    switch (shapeList.SelectedIndex)
                    {
                        case 0:
                            // Négyzet számitás
                            if (x == 0 || y == 0)
                            {
                                throw new Exception("zero");
                            }
                            else
                            {
                                // Terület
                                terulet = x * y;
                                // Kerület
                                kerulet = 2 * (x + y);

                                // Eredmény kiirás
                                debug2.Text = shapeList.SelectedItem.ToString() + " adatai: \n"
                                        + "Terület: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b2" + "\n"
                                        + "Kerület: " + Convert.ToString(Math.Round(kerulet, 2)) + unit;
                                // Előzmény kiirás
                                elozmenyek.Items.Add(shapeList.SelectedItem.ToString() + " adatai: "
                                        + " A oldal: " + x + unit
                                        + " B oldal: " + y + unit
                                        + " Terület: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b2"
                                        + " Kerület: " + Convert.ToString(Math.Round(kerulet, 2)) + unit);
                            }
                            break;
                        case 1:
                            // Kör számitás
                            if (x == 0)
                            {
                                throw new Exception("zero");
                            }
                            else
                            {
                                // Terület
                                terulet = Math.Pow(x, 2) * Math.PI;
                                // Kerület
                                kerulet = (2 * x) * Math.PI;

                                // Eredmény kiirás
                                debug2.Text = shapeList.SelectedItem.ToString() + " adatai: \n"
                                        + "Terület: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b2" + "\n"
                                        + "Kerület: " + Convert.ToString(Math.Round(kerulet, 2)) + unit;
                                // Előzmény kiirás
                                elozmenyek.Items.Add(shapeList.SelectedItem.ToString() + " adatai: "
                                        + " Sugár: " + x + unit
                                        + " Terület: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b2"
                                        + " Kerület: " + Convert.ToString(Math.Round(kerulet, 2)) + unit);
                            }
                            break;
                        case 2:
                            // Kocka számitás
                            if (x == 0)
                            {
                                throw new Exception("zero");
                            }
                            else
                            {
                                // Térfogat
                                terulet = Math.Pow(x, 3);
                                // Felszín
                                kerulet = 6 * Math.Pow(x, 2);
                                // Liter
                                liter = literValtas(terulet);

                                // Eredmény kiirás
                                debug2.Text = shapeList.SelectedItem.ToString() + " adatai: \n"
                                        + "Térfogat: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b3" + "\n"
                                        + "Felszín: " + Convert.ToString(Math.Round(kerulet, 2)) + unit + "\u00b2" + "\n"
                                        + "Liter: " + Math.Round(liter, 2) + " l";
                                // Előzmény kiirás
                                elozmenyek.Items.Add(shapeList.SelectedItem.ToString() + " adatai: "
                                        + " A él: " + x + unit
                                        + " Térfogat: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b3"
                                        + " Felszín: " + Convert.ToString(Math.Round(kerulet, 2)) + unit + "\u00b2"
                                        + " Liter: " + Math.Round(liter, 2) + " l");
                                litermasol.Enabled = true;
                            }
                            break;
                        case 3:
                            // Téglatest számitás
                            if (x == 0 || y == 0 || z == 0)
                            {
                                throw new Exception("zero");
                            }
                            else
                            {
                                // Térfogat
                                terulet = x * y * z;
                                // Felszín
                                kerulet = 2 * ((x * y) + (y * z) + (z * x));
                                // Liter
                                liter = literValtas(terulet);

                                // Eredmény kiirás
                                debug2.Text = shapeList.SelectedItem.ToString() + " adatai: \n"
                                        + "Térfogat: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b3" + "\n"
                                        + "Felszín: " + Convert.ToString(Math.Round(kerulet, 2)) + unit + "\u00b2" + "\n"
                                        + "Liter: " + Math.Round(liter, 2) + " l";
                                // Előzmény kiirás
                                elozmenyek.Items.Add(shapeList.SelectedItem.ToString() + " adatai: "
                                        + " A él: " + x + unit
                                        + " B él: " + y + unit
                                        + " C él: " + z + unit
                                        + " Térfogat: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b3"
                                        + " Felszín: " + Convert.ToString(Math.Round(kerulet, 2)) + unit + "\u00b2"
                                        + " Liter: " + Math.Round(liter, 2) + " l");
                                litermasol.Enabled = true;
                            }
                            break;
                        case 4:
                            // Henger számitás
                            if (x == 0 || y == 0)
                            {
                                throw new Exception("zero");
                            }
                            else
                            {
                                // Térfogat
                                terulet = Math.Pow(x, 2) * Math.PI * y;
                                // Felszín
                                kerulet = 2 * Math.Pow(x, 2) * Math.PI + 2 * x * Math.PI * y;
                                // Liter
                                liter = literValtas(terulet);

                                // Eredmény kiirás
                                debug2.Text = shapeList.SelectedItem.ToString() + " adatai: \n"
                                        + "Térfogat: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b3" + "\n"
                                        + "Felszín: " + Convert.ToString(Math.Round(kerulet, 2)) + unit + "\u00b2" + "\n"
                                        + "Liter: " + Math.Round(liter, 2) + " l";
                                // Előzmény kiirás
                                elozmenyek.Items.Add(shapeList.SelectedItem.ToString() + " adatai: "
                                        + " Sugár: " + x + unit
                                        + " Magasság: " + y + unit
                                        + " Térfogat: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b3"
                                        + " Felszín: " + Convert.ToString(Math.Round(kerulet, 2)) + unit + "\u00b2"
                                        + " Liter: " + Math.Round(liter, 2) + " l");
                                litermasol.Enabled = true;
                            }
                            break;
                        case 5:
                            // Gömb számitás
                            if (x == 0)
                            {
                                throw new Exception("zero");
                            }
                            else
                            {
                                // Térfogat
                                terulet = (4 * Math.Pow(x, 3) * Math.PI) / 3;
                                // Felszín
                                kerulet = 4 * Math.Pow(x, 2) * Math.PI;
                                // Liter
                                liter = literValtas(terulet);

                                // Eredmény kiirás
                                debug2.Text = shapeList.SelectedItem.ToString() + " adatai: \n"
                                        + "Térfogat: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b3" + "\n"
                                        + "Felszín: " + Convert.ToString(Math.Round(kerulet, 2)) + unit + "\u00b2" + "\n"
                                        + "Liter: " + Math.Round(liter, 2) + " l";
                                // Előzmény kiirás
                                elozmenyek.Items.Add(shapeList.SelectedItem.ToString() + " adatai: "
                                        + " Sugár: " + x + unit
                                        + " Térfogat: " + Convert.ToString(Math.Round(terulet, 2)) + unit + "\u00b3"
                                        + " Felszín: " + Convert.ToString(Math.Round(kerulet, 2)) + unit + "\u00b2"
                                        + " Liter: " + Math.Round(liter, 2) + " l");
                                litermasol.Enabled = true;
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                switch (ex.Message.ToString())
                {
                    case "shape": MessageBox.Show("Válassz formát! " + ex.Message.ToString()); break;
                    case "unit": MessageBox.Show("Válassz mértékegységet! " + ex.Message.ToString()); break;
                    case "zero": MessageBox.Show("Hiba a bevitelben! " + ex.Message.ToString()); break;
                    case "string": MessageBox.Show("Ne szöveget irj be! " + ex.Message.ToString()); break;
                }
            }

        }

        // Liter másolo gomb
        private void litermasol_Click(object sender, EventArgs e)
        {
            try
            {
                if (liter <= 0) throw new Exception();
                else TXTgodor.Text = liter.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Nulla literes gödör nem létezik!");
            }
        }

        private void tragyaszamit_Click(object sender, EventArgs e)
        {
            double godorterfogat;
            double.TryParse(TXTgodor.Text, out godorterfogat);

            double tragyaszazalek;
            double.TryParse(TXTtragya.Text, out tragyaszazalek);

            double tragyakell;
            double maradek;
            double x20 = 0;
            double x50 = 0;

            try
            {
                if (godorterfogat == 0 || tragyaszazalek == 0)
                {
                    throw new Exception();
                }

                tragyakell = godorterfogat * (tragyaszazalek / 100);

                x50 = tragyakell / 50;

                if (x50 >= 1)
                {
                    //pl 70l-ed van
                    maradek = tragyakell % 50;

                    if (maradek == 0)
                    {
                        x50 = tragyakell / 50;
                    }
                    else
                    {
                        x50 = tragyakell - maradek;
                        x50 = x50 / 50;
                        // 1db 50l
                        //pl maradék = 23
                        double maradek20 = maradek % 20;
                        // maradek20 = 3
                        if (maradek20 == 0)
                        {
                            x20 = maradek / 20;
                        }
                        else
                        {
                            x20 = maradek - maradek20;
                            x20 = x20 / 20;
                            x20 = x20 + 1;
                        }
                    }
                }
                else
                {
                    maradek = tragyakell % 20;
                    x50 = 0;

                    if (maradek == 0)
                    {
                        x20 = tragyakell / 20;
                    }
                    else
                    {
                        x20 = tragyakell - maradek;
                        x20 = x20 / 20;
                        x20 = x20 + 1;
                    }
                }

                TXTtragyakell.Text = Convert.ToString(Math.Round(tragyakell, 2));
                godorelozmeny.Items.Add(Math.Round(tragyakell, 2) + "L trágya kell. " + x50 + "db 50 literes, " + x20 + "db 20 literes zsák szükséges.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a bevitelben!");
            }

            /*
            if (TXTgodor.Text.Length > 0 && TXTtragya.Text.Length > 0)
            {
                //godorterfogat = Convert.ToDouble(TXTgodor.Text);
                //tragyaszazalek = Convert.ToDouble(TXTtragya.Text);
                
            }
            else
            {
                MessageBox.Show("Üres mezők!");
                godorterfogat = 0;
                tragyaszazalek = 0;
            }*/
        }

        private void buttonLove_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;

            Form2 windowLove = new Form2();
            windowLove.Show();            

            //this.WindowState = FormWindowState.Normal;
        }
    }
}
