using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Model;
using ExpressApp.CustomEditors.Blazor.BaseImpl.SfPdfViewer2;

namespace ExpressApp.CustomEditors.Blazor;

public class SfPdfViewer2PropertyEditor2 : BlazorPropertyEditorBase
{
    public SfPdfViewer2PropertyEditor2(Type objectType, IModelMemberViewItem model) : base(objectType, model)
    {
    }

    public override SfPdfViewer2Model2 ComponentModel => (SfPdfViewer2Model2)base.ComponentModel;

    protected override IComponentModel CreateComponentModel() => new SfPdfViewer2Model2();
}