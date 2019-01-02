using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace InformaticsModel
{
    class LemmaMedia
    {
        private Media[] media_of_lemma;
        private Lemma limma;
        private Media get_media_of_lemma() {
            throw new NotImplementedException();
        }
        private Lemma get_lemma() {
            throw new NotImplementedException();
        }
        public void saveLemmaAsBookmark(String name) { }
        public Collection<Lemma> getLemmaFromCategory(String cat_name) {

            throw new NotImplementedException();
        }
        public void showLemmaList() { }
        public Collection<Lemma> searchTitle(String keyword) { throw new NotImplementedException(); }
        public Collection<Lemma> searchInContent(String keyword) { throw new NotImplementedException(); }
        public void print() { }
        public void export() { }
    }
}
