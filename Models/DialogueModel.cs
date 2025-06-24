namespace StarReverieCore.Models
{
    public class DialogueModel
    {
        public int Id { get; set; }
        public required string SpeakerDialogue { get; set; }
        public required string SpeakerFirstName { get; set; }
        public required string SpeakerMiddleName { get; set; }
        public required string SpeakerLastName { get; set; }
        public string? ListnerDialogue { get; set; }
        public string? ListnerFirstName { get; set; }
        public string? ListnerMiddleName { get; set; }
        public string? ListnerLastName { get; set; }

        // Self-referencing relationship
        public int? ParentDialogueId { get; set; }
        public DialogueModel ParentDialogue { get; set; }
        public List<DialogueModel>? Responses { get; set; }

        public override string ToString()
        {
            return $"{SpeakerFirstName} {SpeakerLastName} Id:{Id}";
        }
    }
}
