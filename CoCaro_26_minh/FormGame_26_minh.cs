namespace CoCaro_26_minh
{
    public partial class formGame_26_minh : Form
    {
        public formGame_26_minh()
        {
            InitializeComponent();
        }
            public formGame_26_minh(string tenNC1_26_minh, string tenNC2_26_minh
                                    ,Image anhNC1_26_minh, Image anhNC2_26_minh,int second)
        {
            InitializeComponent();

           
            cons_26_minh.COOL_DOWN_TIME_26_MINH = cons_26_minh.COOL_DOWN_TIME_26_MINH * second;
            this.Player_26_minh = new List<Player_26_minh>()
            {
                new Player_26_minh(tenNC1_26_minh,Properties.Resources.CaroX_26_minh,anhNC1_26_minh),
                new Player_26_minh(tenNC2_26_minh,Properties.Resources.CaroY_26_minh, anhNC2_26_minh)

            };
            NewGame_26_minh();
            playerMarked_26_minh += chestBoard_playerMarked;
            endedGame_26_minh += chestBoard_endedGame;
            prcbCooldown_26_minh.Step = cons_26_minh.COOL_DOWN_STEP_26_MINH;
            prcbCooldown_26_minh.Maximum = cons_26_minh.COOL_DOWN_TIME_26_MINH;
            prcbCooldown_26_minh.Value = 0;
            tmCoolDown_26_minh.Interval = cons_26_minh.COOL_DOWN_INTERVAL_26_MINH;
            PlayTimeLine_26_minh = new Stack<Point>();

        }

        private Stack  <Point> playTimeLine_26_minh;
        private void chestBoard_endedGame(object? sender, EventArgs e)
        {

            EndGame_26_minh();
        }

        public void NewGame_26_minh()
        {
            prcbCooldown_26_minh.Value = 0;
            tmCoolDown_26_minh.Stop();
             currentPlayer_26_minh = 0;
            changePlayer_26_minh();
            DrawChestBoard_26_minh();
            quayLạiToolStripMenuItem.Enabled = true;
        }

        public void Quit_26_minh()
        {
            tmCoolDown_26_minh.Stop();
            Application.Exit();

        }

        public bool Undo_26_minh()
        {
            if (PlayTimeLine_26_minh.Count == 0)
                return false;
            Point oldPoint_26_minh = PlayTimeLine_26_minh.Pop();
            Button btn_26_minh = martrix_26_minh[oldPoint_26_minh.Y][oldPoint_26_minh.X];
            btn_26_minh.BackgroundImage = null;
            currentPlayer_26_minh = currentPlayer_26_minh == 1 ? 0 : 1;
            changePlayer_26_minh();
            prcbCooldown_26_minh.Value = 0;
            return true;
        }

        void EndGame_26_minh()
        {
            tmCoolDown_26_minh.Stop();
            prcbCooldown_26_minh.Value = 0;
            pnBanCo_26_minh.Enabled = false;
            quayLạiToolStripMenuItem.Enabled = false;
            MessageBox.Show("Trò chơi kết thúc","Thông báo");
        }
        private void chestBoard_playerMarked(object? sender, EventArgs e)
        {

            tmCoolDown_26_minh.Start();
            prcbCooldown_26_minh.Value = 0;
        }

        private List<Player_26_minh> player_26_minh;
        public List<Player_26_minh> Player_26_minh {
            get => player_26_minh; set => player_26_minh = value; 
        }


        private int currentPlayer_26_minh;
        public int CurrentPlayer {
            get => currentPlayer_26_minh; set => currentPlayer_26_minh = value; 
        }
        public List<List<Button>> Martrix_26_minh 
        {
            get => martrix_26_minh; set => martrix_26_minh = value; 
        }
        public Stack<Point> PlayTimeLine_26_minh 
        {
            get => playTimeLine_26_minh; set => playTimeLine_26_minh = value; 
        }

        private List<List<Button>> martrix_26_minh;
        void DrawChestBoard_26_minh()
        {
            pnBanCo_26_minh.Enabled = true;
            pnBanCo_26_minh.Controls.Clear();
            martrix_26_minh = new List<List<Button>>();
            Button oldButton_26_minh = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i_26_minh = 0; i_26_minh <= cons_26_minh.CHEST_BOARD_HEIGHT_26_MINH; i_26_minh++)
            {
                martrix_26_minh.Add(new List<Button>());
                for (int j_26_minh = 0; j_26_minh <= cons_26_minh.CHEST_BOARD_WIDTH_26_MINH; j_26_minh++)
                {
                    Button btn_26_minh = new Button()
                    {
                        Width = cons_26_minh.CHEST_WIDTH_26_MINH,
                        Height = cons_26_minh.CHEST_HEIGHT_26_MINH,
                        Location = new Point(oldButton_26_minh.Location.X + oldButton_26_minh.Width,
                                             oldButton_26_minh.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i_26_minh.ToString()
                    };
                    btn_26_minh.Click += btn_26_minh_Click;
                    pnBanCo_26_minh.Controls.Add(btn_26_minh);
                    martrix_26_minh[i_26_minh].Add(btn_26_minh);
                    oldButton_26_minh = btn_26_minh;

                }
                oldButton_26_minh.Location = new Point(0, oldButton_26_minh.Location.Y + cons_26_minh.CHEST_HEIGHT_26_MINH);
                oldButton_26_minh.Width = 0;
                oldButton_26_minh.Height = 0;
            }
        }

        private event EventHandler playerMarked_26_minh;

        public event EventHandler PlayerMarked_26_minh
        {
            add
            {
                playerMarked_26_minh += value;
            }
            remove
            {
                playerMarked_26_minh -= value;

            }
        }
        public event EventHandler endedGame_26_minh;
        public event EventHandler EndedGame_26_minh
        {
            add
            {
                endedGame_26_minh += value;
            }
            remove
            {
                endedGame_26_minh -= value;

            }
        }



        private void btn_26_minh_Click(object sender, EventArgs e)
        {
            Button? btn_26_minh = sender as Button;
            if (btn_26_minh.BackgroundImage != null)
                return;
            mark_26_minh(btn_26_minh);
            PlayTimeLine_26_minh.Push(getChestPoint_26_minh(btn_26_minh));
            changePlayer_26_minh();
            if (playerMarked_26_minh != null)
            {
                playerMarked_26_minh(this, new EventArgs());
            }
            if (isEndGame_26_minh(btn_26_minh))
            {
                endGame_26_minh();
            }



        }

        private Point getChestPoint_26_minh(Button btn_26_minh)
        {

            int doc_26_minh = Convert.ToInt32(btn_26_minh.Tag);
            int ngang_26_minh = martrix_26_minh[doc_26_minh].IndexOf(btn_26_minh);
            Point point_26_minh = new Point(ngang_26_minh, doc_26_minh);
            return point_26_minh;
        }
        public void endGame_26_minh()
        {
            if (endedGame_26_minh != null)
            {
                endedGame_26_minh(this, new EventArgs());
            }

        }
        private bool isEndGame_26_minh(Button btn_26_minh)
        {
            return isEndGameNgang_26_minh(btn_26_minh) ||
                isEndGameDoc_26_minh(btn_26_minh) ||
                isEndGameCheoChinh_26_minh(btn_26_minh) ||
                isEndGameCheoPhu_26_minh(btn_26_minh);
        }
        private bool isEndGameNgang_26_minh(Button btn_26_minh)
        {
            Point point_26_minh = getChestPoint_26_minh(btn_26_minh);
            int countLeft_26_minh = 0;
            for (int i_26_minh = point_26_minh.X; i_26_minh >= 0; i_26_minh--)
            {
                if (martrix_26_minh[point_26_minh.Y][i_26_minh].BackgroundImage == btn_26_minh.BackgroundImage)
                {
                    countLeft_26_minh++;
                }
                else
                { break; }
            }
            int countRight_26_minh = 0;
            for (int i_26_minh = point_26_minh.X + 1; i_26_minh < cons_26_minh.CHEST_BOARD_WIDTH_26_MINH; i_26_minh++)
            {
                if (martrix_26_minh[point_26_minh.Y][i_26_minh].BackgroundImage == btn_26_minh.BackgroundImage)
                {
                    countRight_26_minh++;
                }
                else
                { break; }
            }
            return countLeft_26_minh + countRight_26_minh == 5;
        }
        private bool isEndGameDoc_26_minh(Button btn_26_minh)
        {

            Point point_26_minh = getChestPoint_26_minh(btn_26_minh);
            int countTop_26_minh = 0;
            for (int i_26_minh = point_26_minh.Y; i_26_minh >= 0; i_26_minh--)
            {
                if (martrix_26_minh[i_26_minh][point_26_minh.X].BackgroundImage == btn_26_minh.BackgroundImage)
                {
                    countTop_26_minh++;
                }
                else
                { break; }
            }
            int countBot_26_minh = 0;
            for (int i_26_minh = point_26_minh.Y + 1; i_26_minh <= cons_26_minh.CHEST_BOARD_HEIGHT_26_MINH; i_26_minh++)
            {
                if (martrix_26_minh[i_26_minh][point_26_minh.X].BackgroundImage == btn_26_minh.BackgroundImage)
                {
                    countBot_26_minh++;
                }
                else
                { break; }
            }
            return countTop_26_minh + countBot_26_minh == 5;
        }
        private bool isEndGameCheoChinh_26_minh(Button btn_26_minh)
        {

            Point point_26_minh = getChestPoint_26_minh(btn_26_minh);
            int countTop_26_minh = 0;
            for (int i_26_minh = 0; i_26_minh <= point_26_minh.X; i_26_minh++)
            {
                if (point_26_minh.X - i_26_minh < 0 || point_26_minh.Y - i_26_minh < 0)
                {
                    break;
                }
                if (martrix_26_minh[point_26_minh.Y - i_26_minh][point_26_minh.X - i_26_minh].BackgroundImage == btn_26_minh.BackgroundImage)
                {
                    countTop_26_minh++;
                }
                else
                { break; }
            }
            int countBot_26_minh = 0;
            for (int i_26_minh = 1; i_26_minh <= cons_26_minh.CHEST_BOARD_WIDTH_26_MINH - point_26_minh.X; i_26_minh++)
            {
                if (point_26_minh.Y + i_26_minh > cons_26_minh.CHEST_BOARD_HEIGHT_26_MINH || point_26_minh.X + i_26_minh > cons_26_minh.CHEST_BOARD_WIDTH_26_MINH)
                {
                    break;
                }
                if (martrix_26_minh[point_26_minh.Y + i_26_minh][point_26_minh.X + i_26_minh].BackgroundImage == btn_26_minh.BackgroundImage)
                {
                    countBot_26_minh++;
                }
                else
                { break; }
            }
            return countTop_26_minh + countBot_26_minh == 5;
        }
        private bool isEndGameCheoPhu_26_minh(Button btn_26_minh)
        {
            Point point_26_minh = getChestPoint_26_minh(btn_26_minh);
            int countTop_26_minh = 0;
            for (int i_26_minh = 0; i_26_minh <= point_26_minh.X; i_26_minh++)
            {
                if (point_26_minh.X + i_26_minh > cons_26_minh.CHEST_BOARD_WIDTH_26_MINH || point_26_minh.Y - i_26_minh < 0)
                {
                    break;
                }
                if (martrix_26_minh[point_26_minh.Y - i_26_minh][point_26_minh.X + i_26_minh].BackgroundImage == btn_26_minh.BackgroundImage)
                {
                    countTop_26_minh++;
                }
                else
                { break; }
            }
            int countBot_26_minh = 0;
            for (int i_26_minh = 1; i_26_minh <= cons_26_minh.CHEST_BOARD_WIDTH_26_MINH - point_26_minh.X; i_26_minh++)
            {
                if (point_26_minh.Y + i_26_minh > cons_26_minh.CHEST_BOARD_HEIGHT_26_MINH || point_26_minh.X - i_26_minh < 0)
                {
                    break;
                }
                if (martrix_26_minh[point_26_minh.Y + i_26_minh][point_26_minh.X - i_26_minh].BackgroundImage == btn_26_minh.BackgroundImage)
                {
                    countBot_26_minh++;
                }
                else
                { break; }
            }
            return countTop_26_minh + countBot_26_minh == 5;
        }
        private void changePlayer_26_minh()
        {
            pbAvt_26_minh.Image = player_26_minh[currentPlayer_26_minh].Avt_26_minh;
            lblTenNguoichoi_26_minh.Text = player_26_minh[currentPlayer_26_minh].Name_26_minh;
        }
        private void mark_26_minh(Button btn_26_minh)
        {
            btn_26_minh.BackgroundImage = player_26_minh[currentPlayer_26_minh].Mark_26_minh;
            currentPlayer_26_minh = currentPlayer_26_minh == 1 ? 0 : 1;
        }

        private void tmCoolDown_26_minh_Tick(object sender, EventArgs e)
        {
            prcbCooldown_26_minh.PerformStep();
            if (prcbCooldown_26_minh.Value >= prcbCooldown_26_minh.Maximum)
            {

                EndGame_26_minh();

            }
        }

        private void chơiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame_26_minh();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Undo_26_minh()==false)
            {
                MessageBox.Show("Không thể quay lại");
                prcbCooldown_26_minh.Value = 0; 
                tmCoolDown_26_minh.Stop();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit_26_minh();
        }

        private void frmGame_26_minh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
               e.Cancel = true;
        }
    }
}
