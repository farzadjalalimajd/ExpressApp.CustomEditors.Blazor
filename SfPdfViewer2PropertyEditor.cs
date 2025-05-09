using DevExpress.ExpressApp.Blazor.Components;
using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Model;
using ExpressApp.CustomEditors.Blazor.BaseImpl.SfPdfViewer2;

namespace ExpressApp.CustomEditors.Blazor;

public class SfPdfViewer2PropertyEditor : BlazorPropertyEditorBase
{
    public SfPdfViewer2PropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
    {
    }

    public override SfPdfViewer2Model ComponentModel => (SfPdfViewer2Model)base.ComponentModel;

    protected override IComponentModel CreateComponentModel() => new SfPdfViewer2Model();

    protected override void ReadValueCore()
    {
        base.ReadValueCore();

        if (PropertyValue is byte[] value)
        {
            ComponentModel.DocumentPath = "data:application/pdf;base64," + Convert.ToBase64String(value);
        }
        else
        {
            ComponentModel.DocumentPath = null;
        }
    }
}
