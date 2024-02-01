namespace GameCaro
{
    public partial class CaroGame : Form
    {
        ChessBoardManager ChessBoard;
        public CaroGame()
        {
            InitializeComponent();

            ChessBoard = new(pnlChessBoard, txtPlayerName);
            NewGame();
        }

        private void Connect(object sender, EventArgs e)
        {
            //btnConnect.Enabled = false;
            //txtIP.ReadOnly = true;
            NewGame();
        }

        void NewGame()
        {
            ChessBoard.DrawChessBoard();
        }
    }
}
