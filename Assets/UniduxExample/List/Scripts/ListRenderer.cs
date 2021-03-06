﻿using UnityEngine;
using UnityEngine.UI;

namespace Unidux.Example.List
{
    public class ListRenderer : MonoBehaviour
    {
        public GameObject ListItem;

        void OnEnable()
        {
            var store = Unidux.Instance.Store;
            this.AddDisableTo(store, Render);
            Render(store.State);
        }

        void Render(State state)
        {
            if (!state.List.IsStateChanged())
            {
                return;
            }

            // remove all child
            foreach (Transform child in this.transform)
            {
                Destroy(child.gameObject);
            }

            // add child
            foreach (string text in state.List.Texts)
            {
                var item = Instantiate(ListItem);
                item.GetComponent<RectTransform>().SetParent(this.GetComponent<RectTransform>(), false);
                item.GetComponent<Text>().text = text;
            }
        }
    }
}
