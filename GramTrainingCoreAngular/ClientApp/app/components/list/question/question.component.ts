import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Question } from '../../../question.model';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.css']
})
export class QuestionComponent implements OnInit {
 @Input() question: Question;
 @Input() selectedAnswer: {answer: number};
 @Input() selectedQuestionIndex: number; 
errorMessage= '';
isShownError = false;
successImages = ['./assets/clapping_Apple_Jack.gif',
'./assets/pinki-clapping.gif'
,'./assets/rainbow-dash.gif'
,'./assets/rainbow-2.gif'
,'./assets/Rarity_clapping.gif'
,'./assets/twilight.gif'
,'./assets/twilight2.gif'
,'./assets/YES_pinkie_pie.gif'
];

  constructor() { }

  ngOnInit() {
  }

  selectAnswer(index: number) {
    if (!this.question.isAnswerChecked){
      this.selectedAnswer.answer = index;
      this.isShownError = false;
      this.question.selectedAnswer = index;
    }
  }

  getClass(i:number){
    let classAnswer = '';
    if (!this.question.isAnswerChecked) {
      classAnswer = this.selectedAnswer.answer === i
      ? 'list-group-item active'
       : 'list-group-item';
    }else {
     if (this.selectedAnswer.answer === i) {
        classAnswer = this.question.isRight ? 'list-group-item list-group-item-success'
       : 'list-group-item list-group-item-danger';
      }else {
        classAnswer =  this.question.rightAnswerIndex === i
        ? 'list-group-item list-group-item-success' : 'list-group-item';
      }
    }
     return classAnswer;
  }

  check() {
    if(this.selectedAnswer.answer !== null) {
    this.question.isRight = this.question.rightAnswerIndex === this.selectedAnswer.answer;
    this.question.isAnswerChecked = true;
    this.question.selectedAnswer = this.selectedAnswer.answer;
    }else {
      this.showError('Виберіть відповідь');
    }
  }

  showError(text: string){
    this.isShownError = true;
    this.errorMessage = text;
  }

  hideError(){
    this.isShownError = false;
    this.errorMessage = '';
  }

  getSuccessImage(){
   let rand = this.getRandomInt(0,this.successImages.length -1);
    return this.successImages[rand];
  }

  getRandomInt(min: number, max: number) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

}
