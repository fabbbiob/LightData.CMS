﻿using System.Collections.Generic;
using EntityWorker.Core.Attributes;
using EntityWorker.Core.Object.Library;


namespace LightData.CMS.Modules.Library
{
    [Table("Articles")]
    public class Article
    {
        [PrimaryKey]
        public System.Guid Id { get; set; }

        [NotNullable]
        public string ArticleName { get; set; }

        public List<MetaKeyword> MetaKeywords { get; set; }

        public bool Published { get; set; }

        [ForeignKey(typeof(Menus))]
        public System.Guid MenusId { get; set; }

        [IndependentData]
        public Menus Menus { get; set; }

        public List<ArticleNode> ArticleNodes { get; set; }

        [ForeignKey(typeof(Article))]
        public System.Guid? ArticleId { get; set; }

        // edited but not published yet
        public List<Article> ArticleTemp { get; set; }

        //Theme
        [ForeignKey(typeof(Folder))]
        public System.Guid? Folder_Id { get; set; }

        public Folder Theme { get; set; }
    }
}
