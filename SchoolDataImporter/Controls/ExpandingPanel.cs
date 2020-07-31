using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SchoolDataImporter.Properties;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.Collections;

namespace SchoolDataImporter.Controls
{
    [Designer(typeof(ExpandingPanelDesigner))]
    public partial class ExpandingPanel : UserControl
    {
        public EventHandler PanelExpanded;

        private Bitmap _expandedImage;
        private Bitmap _collapsedImage;

        private bool _isExpanded = true;
        private string _heading = "Panel Title";

        private int _previousHeight;

        public int ExpandedHeight
        {
            get
            {
                return _previousHeight;
            }
            set
            {
                _previousHeight = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentPanel
        {
            get { return pnlContent; }
        }

        // properties
        public bool IsExpanded
        {
            get
            {
                return _isExpanded;
            }
            set
            {
                _isExpanded = value;
                ToggleExpanded(false);
            }
        }

        public string Heading
        {
            get
            {
                return _heading;
            }
            set
            {
                _heading = value;
                lblHeading.Text = _heading;
            }
        }

        public ExpandingPanel()
        {
            InitializeComponent();
            TypeDescriptor.AddAttributes(pnlContent, new DesignerAttribute(typeof(ExpandingPanelContentDesigner)));
        }

        private void ExpandingPanel_Load(object sender, EventArgs e)
        {
            _expandedImage = Resources.ExpandDown_16x;
            _collapsedImage = Resources.ExpandRight_16x;

            _isExpanded = false;
            ToggleExpanded(false);
        }

        private void UpdateImage()
        {
            pbExpand.Image = _isExpanded ? _expandedImage : _collapsedImage;
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {
            ToggleExpanded(true);
        }

        private void pbExpand_Click(object sender, EventArgs e)
        {
            ToggleExpanded(true);
        }

        public void CollapsePanel()
        {
            _isExpanded = false;
            UpdateImage();
            pnlContent.Visible = false;
            Height = lblHeading.Height + 16;
        }

        public void ToggleExpanded(bool setValue)
        {
            if (setValue)
            {
                _isExpanded = !_isExpanded;
                if (_isExpanded)
                {
                    PanelExpanded?.Invoke(this, new EventArgs());
                }
            }
            UpdateImage();

            pnlContent.Visible = _isExpanded;
            if (!pnlContent.Visible)
            {
                Height = lblHeading.Height + 16;
            }
            else
            {
                Height = _previousHeight;
            }
        }

        private void ExpandingPanel_Resize(object sender, EventArgs e)
        {
            if (_isExpanded)
            {
                _previousHeight = Height;
            }
        }
    }

    public class ExpandingPanelDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            var contentsPanel = ((ExpandingPanel)this.Control).ContentPanel;
            this.EnableDesignMode(contentsPanel, "ContentPanel");
        }
        public override bool CanParent(Control control)
        {
            return false;
        }
        protected override void OnDragOver(DragEventArgs de)
        {
            de.Effect = DragDropEffects.None;
        }
        protected override IComponent[] CreateToolCore(ToolboxItem tool,
            int x, int y, int width, int height, bool hasLocation, bool hasSize)
        {
            return null;
        }
    }

    public class ExpandingPanelContentDesigner : ParentControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                SelectionRules selectionRules = base.SelectionRules;
                selectionRules &= ~SelectionRules.AllSizeable;
                return selectionRules;
            }
        }
        protected override void PostFilterAttributes(IDictionary attributes)
        {
            base.PostFilterAttributes(attributes);
            attributes[typeof(DockingAttribute)] = new DockingAttribute(DockingBehavior.Never);
        }
        protected override void PostFilterProperties(IDictionary properties)
        {
            base.PostFilterProperties(properties);
            var propertiesToRemove = new string[] {
            "Dock", "Anchor",
            "Size", "Location", "Width", "Height",
            "MinimumSize", "MaximumSize",
            "AutoSize", "AutoSizeMode",
            "Visible", "Enabled",
        };
            foreach (var item in propertiesToRemove)
            {
                if (properties.Contains(item))
                    properties[item] = TypeDescriptor.CreateProperty(this.Component.GetType(),
                        (PropertyDescriptor)properties[item],
                        new BrowsableAttribute(false));
            }
        }
    }
}
