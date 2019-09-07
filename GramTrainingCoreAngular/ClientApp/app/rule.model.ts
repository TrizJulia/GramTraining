export class Rule {
    public tense: string;
    public tenses = ['Present Simple', 'Past Simple', 'Present Continious'];
    public rules: any[];

    constructor(tensIndex: number,  public link: string, public isImage  = true,
         public isYoutube = false) {
        this.tense =  this.tenses[tensIndex];
    }
}