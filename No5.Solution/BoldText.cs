﻿namespace No5.Solution
{
    public class BoldText : DocumentPart
    {
        public override string ToHtml() => "<b>" + this.Text + "</b>";

        public override string ToPlainText() => "**" + this.Text + "**";

        public override string ToLaTeX() => "\\textbf{" + this.Text + "}";

        public BoldText(string text) : base(text)
        {
        }
    }
}