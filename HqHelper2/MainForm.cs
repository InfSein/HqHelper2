namespace HqHelper2
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); }

        #region Constant Predefs
        private Dictionary<Button, string> PatchButtons = new();
        private bool isMainLeftFolded = false;
        private float oriMainLeftWidth;

        #endregion

        #region Load Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitConstants();
        }

        private void InitConstants()
        {
            PatchButtons = new()
            {
                { BTN_MAIN_LEFT_PATCH1, BTN_MAIN_LEFT_PATCH1.Text },
                { BTN_MAIN_LEFT_PATCH2, BTN_MAIN_LEFT_PATCH2.Text }, 
                { BTN_MAIN_LEFT_PATCH3, BTN_MAIN_LEFT_PATCH3.Text },
                { BTN_MAIN_LEFT_PATCH4, BTN_MAIN_LEFT_PATCH4.Text }, 
                { BTN_MAIN_LEFT_PATCH5, BTN_MAIN_LEFT_PATCH5.Text }
            };
            oriMainLeftWidth = MainTlp.ColumnStyles[0].Width;
        }
        #endregion

        #region ButtonClickEvents
        private void BTN_MAIN_LEFT_FoldOrRelease_Click(object sender, EventArgs e)
        {
            foreach(var pb in PatchButtons)
            {
                pb.Key.Text = isMainLeftFolded ? pb.Value : "";
            }
            BTN_MAIN_LEFT_FoldOrRelease.Text = isMainLeftFolded ? "ÕÛµþ <<" : "Õ¹¿ª >>";
            //BTN_MAIN_LEFT_FoldOrRelease.TextAlign = isMainLeftFolded 
            //    ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;
            //BTN_MAIN_LEFT_FoldOrRelease.Anchor = isMainLeftFolded
            //    ? AnchorStyles.Right : AnchorStyles.Left;
            MainTlp.ColumnStyles[0].Width = isMainLeftFolded ? oriMainLeftWidth : 7F;
            isMainLeftFolded = !isMainLeftFolded;
        }
        #endregion
    }
}