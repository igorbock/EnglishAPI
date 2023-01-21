namespace EnglishAPI.Interfaces;

public interface IUnit
{
    public int cd_code { get; set; }
    public int? cd_word_bank { get; set; }
    public int? cd_straight_to_the_point { get; set; }
    public int? cd_easy_to_understand { get; set; }
    public int? cd_state { get; set; }
    public int? cd_listening_comprehension { get; set; }
    public int? cd_its_time_to_talk { get; set; }
    public int? cd_asking_questions { get; set; }
}
