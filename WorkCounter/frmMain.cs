using WorkCounter.Views;

namespace WorkCounter
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        useDashboard Dashboard = new useDashboard {Dock = System.Windows.Forms.DockStyle.Fill };


        public frmMain()
        {

            InitializeComponent();
            Prepare();
        }
        
        private void Prepare()
        {
            this.fluentDesignFormContainer1.Controls.Add(this.Dashboard);
        }
    }
}
