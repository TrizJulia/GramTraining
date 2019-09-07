import {Rule} from './rule.model';
export class Question{
    public isAnswerChecked = false;
    public isRight = false;
    public selectedAnswer: number = null;
    constructor(public questionText: string,
       public englishAnswers: string[], public rightAnswerIndex: number, public rule: Rule) {   
        this.isAnswerChecked = false;
        this.isRight = false;
    }
}
