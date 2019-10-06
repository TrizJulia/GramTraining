import { QuestionService } from '../../../../services/question.service';
import { Component, OnInit } from '@angular/core';
import { Question } from '../../../../question.model';

@Component({
  selector: 'app-questions-list',
  templateUrl: './questions-list.component.html',
  styleUrls: ['./questions-list.component.css']
})
export class QuestionsListComponent implements OnInit {

  questions: Question[] = []
  constructor(private questionService: QuestionService) { }

  ngOnInit() {
    this.questions = this.questionService.getQuestions();
   
  }

  selectQuestion(id: number){
    console.log("selectedQuestion id" + id + "question" + this.questions);
    this.questionService.questionSelected.next(this.questions[id]);
  }

}
