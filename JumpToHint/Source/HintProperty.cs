using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Text.Editor;

namespace JumpToHint
{
//    public internal enum HintState
    public enum HintState
    {
        /// <summary>
        /// 無効
        /// </summary>
        Disabled,

        /// <summary>
        /// キー入力受付中（ヒント表示中）
        /// </summary>
        Receiving,
    }

    public enum HintMode
    {
        /// <summary>
        /// Word単位
        /// </summary>
        Word,

        /// <summary>
        /// Line単位
        /// </summary>
        Line,
    }

    public class HintProperty
    {
        private readonly IWpfTextView _textView;
        private HintState _state = HintState.Disabled;
        private HintMode _mode = HintMode.Word;
        private string _inputChars = "";

        public IWpfTextView TextView
        {
            get { return _textView; }
        }

        public HintState State
        {
            get { return _state; }
        }

        public HintMode Mode
        {
            get { return _mode; }
        }

        internal HintProperty(IWpfTextView textView)
        {
            _textView = textView;
            Initialize();
        }

        private void Initialize()
        {
            _state = HintState.Disabled;
            _inputChars = "";
        }

        public string GetText()
        {
            return "Test";
        }
    }
}