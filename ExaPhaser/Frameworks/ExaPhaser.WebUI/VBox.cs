using JSIL.Dom;

namespace ExaPhaser.WebUI
{
    public class VBox : Container
    {
        public VBox()
        {
            SetStyle("overflow", "auto");
            SetStyle("width", "100%");
        }

        protected override Element Prepare(Element childElement)
        {
            var wrapper = base.Prepare(childElement);
            wrapper.SetStyle("clear", "both");
            return wrapper;
        }
    }
}