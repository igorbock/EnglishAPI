namespace EnglishAPI.Models;

public class Word : IWord
{
    public int cd_code { get; set; }
    public string ds_word { get; set; }
    public int cd_word_bank { get; set; }
}
