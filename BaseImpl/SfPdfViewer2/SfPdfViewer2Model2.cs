using DevExpress.ExpressApp.Blazor.Components.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.SfPdfViewer;

namespace ExpressApp.CustomEditors.Blazor.BaseImpl.SfPdfViewer2;

public class SfPdfViewer2Model2 : ComponentModelBase
{
    public string? DownloadFileName
    {
        get => GetPropertyValue<string?>();
        set => SetPropertyValue(value);
    }

    public bool EnableFormFields
    {
        get => GetPropertyValue<bool>();
        set => SetPropertyValue(value);
    }

    public int ZoomValue
    {
        get => GetPropertyValue<int>();
        set => SetPropertyValue(value);
    }

    public bool EnableErrorDialog
    {
        get => GetPropertyValue<bool>(true);
        set => SetPropertyValue(value);
    }

    public SfPdfViewer2Model? ComponentModel
    {
        get => GetPropertyValue<SfPdfViewer2Model?>();
        set => SetPropertyValue(value);
    }

    public string? DocumentPath
    {
        get => GetPropertyValue<string?>();
        set => SetPropertyValue(value);
    }

    public EventCallback<DocumentEditedEventArgs> DocumentEdited
    {
        get => GetPropertyValue<EventCallback<DocumentEditedEventArgs>>();
        set => SetPropertyValue(value);
    }

    public EventCallback<LoadEventArgs> DocumentLoaded
    {
        get => GetPropertyValue<EventCallback<LoadEventArgs>>();
        set => SetPropertyValue(value);
    }

    public bool EnableContextMenu
    {
        get => GetPropertyValue<bool>(true);
        set => SetPropertyValue(value);
    }

    public List<ToolbarItem> ToolbarItems
    {
        get => GetPropertyValue<List<ToolbarItem>>(
            [
                ToolbarItem.OpenOption,
                ToolbarItem.PageNavigationTool,
                ToolbarItem.MagnificationTool,
                ToolbarItem.SelectionTool,
                ToolbarItem.PanTool,
                ToolbarItem.UndoRedoTool,
                ToolbarItem.CommentTool,
                ToolbarItem.SubmitForm,
                ToolbarItem.SearchOption,
                ToolbarItem.AnnotationEditTool,
                ToolbarItem.PrintOption,
                ToolbarItem.DownloadOption
            ]);
        set => SetPropertyValue(value);
    }

    public override Type ComponentType => typeof(SfPdfViewer2Renderer2);
}