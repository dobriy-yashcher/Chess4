using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChessCore;

namespace WpfChess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Piece piece;
        private List<string> piecesNames;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Field_Click(object sender, RoutedEventArgs e)
        {
            bool enableBoard = true;
            string selectPiece = "";

            Button clickedButton = (Button)sender;
            int row = Grid.GetRow(clickedButton) - 1;
            int col = Grid.GetColumn(clickedButton) - 1;

            //clear
            if (clickedButton.Content.ToString() != "" && piece != null)
            {
                clickedButton.Content = "";
                piece = null;
                return;
            }

            if (lbShapes.SelectedItem != null)
            {
                // set piece
                if (clickedButton.Content.ToString() == "" && piece == null)
                {
                    var selPieceName = lbShapes.SelectedItem.ToString();
                    var findName = selPieceName.Split();
                    selPieceName = findName[findName.Length - 1];


                    clickedButton.Content = selPieceName;
                    piece = PieceMaker.Make(selPieceName, col, row);
                    selPieceName = "";

                    return;
                }


                while ((Button)sender != null)
                {
                    // move
                    var currentButton = GetButton(piece.x, piece.y);
                    //var currentButton = clickedButton;
                    if (piece.isRightMove(col, row))
                    {
                        piece.Move(col, row);
                        clickedButton.Content = currentButton.Content;
                        currentButton.Content = "";
                    }
                }
                

            }

            else MessageBox.Show("Select chess shape, please.");
        }

        private Button GetButton(int row, int column)
        {
            ++column;
            ++row;

            foreach (Button child in grLayout.Children)
            {
                if (Grid.GetRow(child) == row && Grid.GetColumn(child) == column)
                {
                    return child;
                }
            }
            return null;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button selectedButton = (Button)sender;
            int row = Grid.GetRow(selectedButton)-1;
            int col = Grid.GetColumn(selectedButton)-1;
            if (piece != null && selectedButton.Content.ToString() == "")
            {
                selectedButton.Content = piece.isRightMove(col, row) ? "YES" : "NO";
            }
        }
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button selectedButton = (Button)sender;
            string content = selectedButton.Content.ToString();
            if (content == "YES" || content == "NO")
            {
                selectedButton.Content = "";
            }
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            foreach (Button child in grLayout.Children)
            {
                child.Content = "";
            }
        }
    }
}