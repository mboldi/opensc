using OpenSC.Model.Routers;
using System.Windows.Forms;

namespace OpenSC.GUI.Routers
{
    public partial class SWP08RouterEditorForm : RouterEditorFormBase, IModelEditorForm<Router>
    {
        public SWP08RouterEditorForm()
        {
            InitializeComponent();
        }

        public IModelEditorForm GetInstance(object modelInstance)
        {
            throw new System.NotImplementedException();
        }

        public IModelEditorForm<Router> GetInstanceT(Router modelInstance)
        {
            throw new System.NotImplementedException();
        }
    }
}
