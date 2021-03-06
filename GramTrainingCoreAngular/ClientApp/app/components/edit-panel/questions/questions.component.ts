import { Question } from './../../../question.model';
import { Component, OnInit } from '@angular/core';
import { QuestionService } from '../../../services/question.service';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent implements OnInit {  
  selectedQuestion: Question
  constructor(private questionService: QuestionService) { }

  ngOnInit() {
    this.questionService.questionSelected
    .subscribe((question:Question)=>{
      console.log("question from details" + question);
      this.selectedQuestion = question;
    })
  }

}
