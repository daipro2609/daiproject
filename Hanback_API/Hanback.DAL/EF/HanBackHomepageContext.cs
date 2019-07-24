using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hanback.DAL.EF
{
    public partial class HanBackHomepageContext : DbContext
    {
        public HanBackHomepageContext()
        {
        }

        public HanBackHomepageContext(DbContextOptions<HanBackHomepageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HpMasArticleCategory> HpMasArticleCategory { get; set; }
        public virtual DbSet<HpMasArticleMedia> HpMasArticleMedia { get; set; }
        public virtual DbSet<HpMasArticles> HpMasArticles { get; set; }
        public virtual DbSet<HpMasCategory> HpMasCategory { get; set; }
        public virtual DbSet<HpMasComment> HpMasComment { get; set; }
        public virtual DbSet<HpMasConfig> HpMasConfig { get; set; }
        public virtual DbSet<HpMasExperts> HpMasExperts { get; set; }
        public virtual DbSet<HpMasMenu> HpMasMenu { get; set; }
        public virtual DbSet<HpMasSlide> HpMasSlide { get; set; }
        public virtual DbSet<HpMasUser> HpMasUser { get; set; }
        public virtual DbSet<HpTnsEmailSubcribed> HpTnsEmailSubcribed { get; set; }
        public virtual DbSet<HpTnsFeedback> HpTnsFeedback { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=52.78.132.235;Database=HanBackHomepage;Trusted_Connection=False;user=sa;password=atmaneuler0197");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<HpMasArticleCategory>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.CategoryId })
                    .HasName("PK_ARTICLE_CATEGORY");

                entity.ToTable("HP_MAS_ARTICLE_CATEGORY");

                entity.Property(e => e.ArticleId).HasColumnName("ARTICLE_ID");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
            });

            modelBuilder.Entity<HpMasArticleMedia>(entity =>
            {
                entity.HasKey(e => e.MediaId);

                entity.ToTable("HP_MAS_ARTICLE_MEDIA");

                entity.Property(e => e.MediaId).HasColumnName("MEDIA_ID");

                entity.Property(e => e.ArticleId).HasColumnName("ARTICLE_ID");

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("CHANGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("LINK")
                    .HasMaxLength(500);

                entity.Property(e => e.MediaType).HasColumnName("MEDIA_TYPE");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<HpMasArticles>(entity =>
            {
                entity.HasKey(e => e.ArticleId);

                entity.ToTable("HP_MAS_ARTICLES");

                entity.Property(e => e.ArticleId).HasColumnName("ARTICLE_ID");

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("CHANGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CommentCount).HasColumnName("COMMENT_COUNT");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnName("CONTENTS");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('20161223')");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.Images)
                    .HasColumnName("IMAGES")
                    .HasMaxLength(500);

                entity.Property(e => e.LikeCount).HasColumnName("LIKE_COUNT");

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("META_DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.MetaKeywords)
                    .HasColumnName("META_KEYWORDS")
                    .HasMaxLength(200);

                entity.Property(e => e.PublishDate)
                    .HasColumnName("PUBLISH_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rating).HasColumnName("RATING");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);

                entity.Property(e => e.Tags)
                    .HasColumnName("TAGS")
                    .HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(300);

                entity.Property(e => e.UseYn).HasColumnName("USE_YN");
            });

            modelBuilder.Entity<HpMasCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("HP_MAS_CATEGORY");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Attr1)
                    .HasColumnName("ATTR1")
                    .HasMaxLength(100);

                entity.Property(e => e.Attr2)
                    .HasColumnName("ATTR2")
                    .HasMaxLength(100);

                entity.Property(e => e.Attr3)
                    .HasColumnName("ATTR3")
                    .HasMaxLength(100);

                entity.Property(e => e.Attr4)
                    .HasColumnName("ATTR4")
                    .HasMaxLength(100);

                entity.Property(e => e.Attr5)
                    .HasColumnName("ATTR5")
                    .HasMaxLength(100);

                entity.Property(e => e.CateName)
                    .IsRequired()
                    .HasColumnName("CATE_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("CHANGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.IsMenu).HasColumnName("IS_MENU");

                entity.Property(e => e.IsSystem).HasColumnName("IS_SYSTEM");

                entity.Property(e => e.MetaDescription)
                    .HasColumnName("META_DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.MetaKeyword)
                    .HasColumnName("META_KEYWORD")
                    .HasMaxLength(200);

                entity.Property(e => e.PageLink)
                    .HasColumnName("PAGE_LINK")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);

                entity.Property(e => e.UrlRewrite)
                    .HasColumnName("URL_REWRITE")
                    .HasMaxLength(100);

                entity.Property(e => e.UseYn).HasColumnName("USE_YN");
            });

            modelBuilder.Entity<HpMasComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("HP_MAS_COMMENT");

                entity.Property(e => e.CommentId).HasColumnName("COMMENT_ID");

                entity.Property(e => e.ArticleId).HasColumnName("ARTICLE_ID");

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("CHANGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("MEMBER_ID");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("MESSAGE")
                    .HasMaxLength(1000);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("PHONE")
                    .HasMaxLength(20);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HpMasConfig>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("HP_MAS_CONFIG");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("CHANGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<HpMasExperts>(entity =>
            {
                entity.HasKey(e => e.EmployeesId)
                    .HasName("PK_HP_MAS_EMPLOYEES");

                entity.ToTable("HP_MAS_EXPERTS");

                entity.Property(e => e.EmployeesId).HasColumnName("EMPLOYEES_ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(500);

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasColumnName("AVATAR")
                    .HasMaxLength(250);

                entity.Property(e => e.Birthday)
                    .HasColumnName("BIRTHDAY")
                    .HasMaxLength(20);

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("CHANGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("GENDER")
                    .HasMaxLength(10);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("MOBILE")
                    .HasMaxLength(15);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnName("POSITION")
                    .HasMaxLength(100);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<HpMasMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.ToTable("HP_MAS_MENU");

                entity.Property(e => e.MenuId).HasColumnName("MENU_ID");

                entity.Property(e => e.ChangTime)
                    .HasColumnName("CHANG_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.Link)
                    .HasColumnName("LINK")
                    .HasMaxLength(500);

                entity.Property(e => e.MenuType).HasColumnName("MENU_TYPE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);

                entity.Property(e => e.UseYn).HasColumnName("USE_YN");
            });

            modelBuilder.Entity<HpMasSlide>(entity =>
            {
                entity.ToTable("HP_MAS_SLIDE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("CHANGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000);

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .HasColumnName("IMAGES")
                    .HasMaxLength(300);

                entity.Property(e => e.Link)
                    .HasColumnName("LINK")
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(300);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);

                entity.Property(e => e.SlideType).HasColumnName("SLIDE_TYPE");

                entity.Property(e => e.UseYn).HasColumnName("USE_YN");
            });

            modelBuilder.Entity<HpMasUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("HP_MAS_USER");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Avatar)
                    .HasColumnName("AVATAR")
                    .HasMaxLength(300);

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("CHANGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(20);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.UseYn).HasColumnName("USE_YN");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HpTnsEmailSubcribed>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK__HP_TNS_E__161CF7256C13EBA7");

                entity.ToTable("HP_TNS_EMAIL_SUBCRIBED");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeTime)
                    .HasColumnName("CHANGE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Changer)
                    .HasColumnName("CHANGER")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('20161223')");

                entity.Property(e => e.Creator)
                    .HasColumnName("CREATOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Fullname)
                    .HasColumnName("FULLNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(400);

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasMaxLength(100);

                entity.Property(e => e.UnsubcribedDate)
                    .HasColumnName("UNSUBCRIBED_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UnsubcribedMessage)
                    .HasColumnName("UNSUBCRIBED_MESSAGE")
                    .HasMaxLength(500);

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("USE_YN")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HpTnsFeedback>(entity =>
            {
                entity.ToTable("HP_TNS_FEEDBACK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category).HasMaxLength(250);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasColumnName("REMARK")
                    .HasMaxLength(1000);

                entity.Property(e => e.ReplyBy)
                    .HasColumnName("REPLY_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyMessage).HasColumnName("REPLY_MESSAGE");

                entity.Property(e => e.ReplyTime)
                    .HasColumnName("REPLY_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReplyYn).HasColumnName("REPLY_YN");

                entity.Property(e => e.Type).HasColumnName("TYPE");
            });
        }
    }
}
