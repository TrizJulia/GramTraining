import {Rule} from './rule.model';
export class Question{
    public isAnswerChecked = false;
    public isRight = false;
    public selectedAnswer: number = null;
    constructor(public id: number, public questionText: string,
       public answers: string[], public rightAnswerIndex: number, public rule: Rule) {   
        this.isAnswerChecked = false;
        this.isRight = false;
    }
}
