using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Model;
using ExpressApp.CustomEditors.Blazor.BaseImpl.DxPdfViewer;

namespace ExpressApp.CustomEditors.Blazor;

public class DxPdfViewerPropertyEditor : BlazorPropertyEditorBase
{
    public DxPdfViewerPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
    {
    }

    public override DxPdfViewerModel ComponentModel => (DxPdfViewerModel)base.ComponentModel;

    protected override IComponentModel CreateComponentModel() => new DxPdfViewerModel();

    protected override void ReadValueCore()
    {
        base.ReadValueCore();

        ComponentModel.DocumentContent = (byte[])PropertyValue;
    }
}