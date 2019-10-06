import { Component, OnInit, Input } from '@angular/core';
import { Question } from '../../../../question.model';
import { QuestionService } from '../../../../services/question.service';

@Component({
  selector: 'app-question-details',
  templateUrl: './question-details.component.html',
  styleUrls: ['./question-details.component.css']
})
export class QuestionDetailsComponent implements OnInit {
  @Input() question: Question;

  constructor(private questionService: QuestionService) { }

  ngOnInit() {
   
  }

}
