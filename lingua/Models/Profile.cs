using System;
using System.Collections.Generic;

namespace lingua.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public int? UserId { get; set; }

    public byte? EnglishLevel { get; set; }

    public byte? GrammarLevel { get; set; }

    public byte? WritingLevel { get; set; }

    public byte? ListeningLevel { get; set; }

    public byte? SpeakingLevel { get; set; }

    public int? LearnedVocabulary { get; set; }

    public int? StudyTimePerDay { get; set; }

    public int? VocabularySize { get; set; }

    public byte[]? ProfilePicture { get; set; }

    public virtual User? User { get; set; }
}
