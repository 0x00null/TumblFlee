using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class PostCollection : IEnumerable<PostInfo>
    {
        private IEnumerable<PostInfo> _source;
        private Lazy<PostCollectionView> _textPosts;
        private Lazy<PostCollectionView> _quotePosts;
        private Lazy<PostCollectionView> _linkPosts;
        private Lazy<PostCollectionView> _answerPosts;
        private Lazy<PostCollectionView> _videoPosts;
        private Lazy<PostCollectionView> _audioPosts;
        private Lazy<PostCollectionView> _photoPosts;
        private Lazy<PostCollectionView> _chatPosts;

        public PostCollectionView TextPosts { get { return _textPosts.Value; } }
        public PostCollectionView QuotePosts { get { return _quotePosts.Value; } }
        public PostCollectionView LinkPosts { get { return _linkPosts.Value; } }
        public PostCollectionView AnswerPosts { get { return _answerPosts.Value; } }
        public PostCollectionView VideoPosts { get { return _videoPosts.Value; } }
        public PostCollectionView AudioPosts { get { return _audioPosts.Value; } }
        public PostCollectionView PhotoPosts { get { return _photoPosts.Value; } }
        public PostCollectionView ChatPosts { get { return _chatPosts.Value; } }

        public PostCollection(IEnumerable<PostInfo> source)
        {
            _source = source;
            _textPosts = new Lazy<PostCollectionView>(() => new PostCollectionView(this, p => p.Type == "text"));
            _quotePosts = new Lazy<PostCollectionView>(() => new PostCollectionView(this, p => p.Type == "quote"));
            _linkPosts = new Lazy<PostCollectionView>(() => new PostCollectionView(this, p => p.Type == "link"));
            _answerPosts = new Lazy<PostCollectionView>(() => new PostCollectionView(this, p => p.Type == "answer"));
            _videoPosts = new Lazy<PostCollectionView>(() => new PostCollectionView(this, p => p.Type == "video"));
            _audioPosts = new Lazy<PostCollectionView>(() => new PostCollectionView(this, p => p.Type == "audio"));
            _photoPosts = new Lazy<PostCollectionView>(() => new PostCollectionView(this, p => p.Type == "photo"));
            _chatPosts = new Lazy<PostCollectionView>(() => new PostCollectionView(this, p => p.Type == "chat"));
        }

        public IEnumerator<PostInfo> GetEnumerator()
        {
            return _source.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class PostCollectionView
    {
        private readonly PostCollection source;
        private readonly Func<PostInfo, bool> filter;

        public PostCollectionView(PostCollection source, Func<PostInfo, Boolean> filter)
        {
            this.source = source;
            this.filter = filter;
        }

        public IEnumerable<PostInfo> Originals
        {
            get
            {
                return source.Where(filter).Where(p => string.IsNullOrEmpty(p.RebloggedFrom));
            }
        }

        public IEnumerable<PostInfo> Reblogs
        {
            get
            {
                return source.Where(filter).Where(p => !string.IsNullOrEmpty(p.RebloggedFrom));
            }
        }

    }
}
