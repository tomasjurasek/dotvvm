using DotVVM.Framework.Binding;
using DotVVM.Framework.Controls;

namespace DotVVM.Framework.Compilation.ControlTree
{
    public interface IPropertyDescriptor: IControlAttributeDescriptor
    {
        string Name { get; }
        bool IsBindingProperty { get; }
        string FullName { get; }
        bool IsVirtual { get; }
    }
}