using Coldsteel;
using Coldsteel.Rendering;
using Coldsteel.Scripting;
using System.Collections.Generic;
using System.Linq;

namespace MonoGameJamFeb2018.Entities
{
    class ListView<T> : Entity
    {
        private List<ListViewItem> _listViewItems;

        public ListView(IEnumerable<T> items, ListViewConfig<T> config)
        {
            var listViewItems = items
                .Select(item => new ListViewItem(item, config))
                .ToList();

            listViewItems.ForEach(i => this.AddChild(i));

            AddComponent(new ListViewController(listViewItems));

            _listViewItems = listViewItems;
        }

        protected override void OnActivated()
        {
            for (int y = 0; y < _listViewItems.Count; y++)
                _listViewItems[y].TranslateToLocal(0, y * _listViewItems[y].TextRenderer.SpriteFont.Value.LineSpacing);
        }

        private class ListViewController : Behavior
        {
            private int _selectedIdx;

            private ListViewItem[] _listViewOptions;

            public ListViewController(IEnumerable<ListViewItem> listViewItems)
            {
                _selectedIdx = 0;
                _listViewOptions = listViewItems.ToArray();
                _listViewOptions[_selectedIdx].Select();
            }

            public override void OnUpdate()
            {
                if (Input.GetButton("MenuDown").WasPressed) UpdateSelectedIndex(_selectedIdx + 1);
                else if (Input.GetButton("MenuUp").WasPressed) UpdateSelectedIndex(_selectedIdx - 1);
                else if (Input.GetButton("MenuEnter").WasPressed) EnterSelectedIndex();
            }

            private void UpdateSelectedIndex(int newIdx)
            {
                _listViewOptions[_selectedIdx].Deselect();
                if (newIdx < 0) newIdx = _listViewOptions.Length - 1;
                if (newIdx >= _listViewOptions.Length) newIdx = 0;
                _selectedIdx = newIdx;
                _listViewOptions[_selectedIdx].Select();
            }

            private void EnterSelectedIndex()
            {
                _listViewOptions[_selectedIdx].Enter();
            }
        }

        private class ListViewItem : Entity
        {
            public TextRenderer TextRenderer { get; }

            private T _item;

            private ListViewConfig<T> _config;

            public ListViewItem(T item, ListViewConfig<T> config)
            {
                _item = item;
                _config = config;
                this.AddTextRenderer(config.Font, 
                    text: config.NameSelector(item), 
                    color: config.Color,
                    origin: config.Origin);
                TextRenderer = GetComponent<TextRenderer>();
            }

            public void Select()
            {
                TextRenderer.Color = _config.SelectedColor;
                _config.OnSelect?.Invoke(_item);
            }

            public void Enter()
            {
                _config.OnChoose?.Invoke(_item);
            }

            public void Deselect()
            {
                TextRenderer.Color = _config.Color;
                _config.OnDeselect?.Invoke(_item);
            }
        }
    }
}
