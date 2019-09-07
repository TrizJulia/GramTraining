import { Component, OnInit } from '@angular/core';
import { Question } from '../../question.model';
import { Rule } from '../../rule.model';
import {questionsWithSpecialWords} from '../../questionsSpecialWords';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  questions: Question[] = questionsWithSpecialWords;
  selectedQuestion: Question = this.questions[0];
  selectedAnswer: {answer: number} = {answer: null};
  selectedQuestionIndex = 0;
  errorMessage: string = 'нема помилок';

  constructor() {
   }

  ngOnInit() {
  }

  goToNext() {
    this.selectedQuestionIndex++;
    this.selectedQuestion = this.questions[this.selectedQuestionIndex];
    this.selectedAnswer.answer = null;
  }

  goToPrev() {
    this.selectedQuestionIndex--;
    this.selectedQuestion = this.questions[this.selectedQuestionIndex];
    this.selectedAnswer.answer = this.questions[this.selectedQuestionIndex].selectedAnswer;
  }

  showErrorMessage(text:string){
      this.errorMessage = text;
  }

}
