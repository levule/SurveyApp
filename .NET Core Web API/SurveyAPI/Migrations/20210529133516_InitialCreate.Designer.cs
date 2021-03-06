// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurveyAPI.Models;

namespace SurveyAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20210529133516_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SurveyAPI.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionAnswersId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionAnswersId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("SurveyId");

                    b.HasIndex(new[] { "ParticipantId", "SurveyId", "QuestionId", "QuestionAnswersId" }, "UN_Answers_ParticipantId_SurveyId_QuestionId_QuestionAnswersId")
                        .IsUnique();

                    b.ToTable("Answers", "Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.GeneralInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("GeneralInformations", "Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.OfferedAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("OfferedAnswers", "Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Participants", "Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions", "Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.QuestionOfferedAnswerRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("OfferedAnswerId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfferedAnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionOfferedAnswerRelations", "Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.SurveyQuestionRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChangedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveyQuestionRelations", "Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.Answer", b =>
                {
                    b.HasOne("SurveyAPI.Models.Participant", "Participant")
                        .WithMany("Answers")
                        .HasForeignKey("ParticipantId")
                        .HasConstraintName("FK_Answers_ParticipantId")
                        .IsRequired();

                    b.HasOne("SurveyAPI.Models.OfferedAnswer", "QuestionAnswers")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionAnswersId")
                        .HasConstraintName("FK_Answers_OfferedAnswersId")
                        .IsRequired();

                    b.HasOne("SurveyAPI.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FK_Answers_QuestionId")
                        .IsRequired();

                    b.HasOne("SurveyAPI.Models.GeneralInformation", "Survey")
                        .WithMany("Answers")
                        .HasForeignKey("SurveyId")
                        .HasConstraintName("FK_Answers_SurveyId")
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("Question");

                    b.Navigation("QuestionAnswers");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.Participant", b =>
                {
                    b.HasOne("SurveyAPI.Models.GeneralInformation", "Survey")
                        .WithMany("Participants")
                        .HasForeignKey("SurveyId")
                        .HasConstraintName("FK_Participants_SurveyId")
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.QuestionOfferedAnswerRelation", b =>
                {
                    b.HasOne("SurveyAPI.Models.OfferedAnswer", "OfferedAnswer")
                        .WithMany("QuestionOfferedAnswerRelations")
                        .HasForeignKey("OfferedAnswerId")
                        .HasConstraintName("FK_QuestionOfferedAnswerRelations_OfferedAnswerId")
                        .IsRequired();

                    b.HasOne("SurveyAPI.Models.Question", "Question")
                        .WithMany("QuestionOfferedAnswerRelations")
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FK_QuestionOfferedAnswerRelations_QuestionId")
                        .IsRequired();

                    b.Navigation("OfferedAnswer");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("SurveyAPI.Models.SurveyQuestionRelation", b =>
                {
                    b.HasOne("SurveyAPI.Models.Question", "Question")
                        .WithMany("SurveyQuestionRelations")
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FK_SurveyQuestionRelations_QuestionId")
                        .IsRequired();

                    b.HasOne("SurveyAPI.Models.GeneralInformation", "Survey")
                        .WithMany("SurveyQuestionRelations")
                        .HasForeignKey("SurveyId")
                        .HasConstraintName("FK_SurveyQuestionRelations_SurveyId")
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SurveyAPI.Models.GeneralInformation", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Participants");

                    b.Navigation("SurveyQuestionRelations");
                });

            modelBuilder.Entity("SurveyAPI.Models.OfferedAnswer", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("QuestionOfferedAnswerRelations");
                });

            modelBuilder.Entity("SurveyAPI.Models.Participant", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("SurveyAPI.Models.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("QuestionOfferedAnswerRelations");

                    b.Navigation("SurveyQuestionRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
