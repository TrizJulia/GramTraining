import { Component, OnInit } from '@angular/core';
import { Rule } from '../../rule.model';

@Component({
  selector: 'app-rules',
  templateUrl: './rules.component.html',
  styleUrls: ['./rules.component.css']
})
export class RulesComponent implements OnInit {
  prSimRules: Rule[] = [
    new Rule(0, './assets/prezent-simpl-tablitsa.png', false, true),
    new Rule(0, 'https://youtu.be/eUXkj6j6Ezw', false, true),
  ];
  prContRules: Rule[] = [];
  pastSimpleRules: Rule[] = [];
  tenses = ['Present Simple', 'Past Simple', 'Present Continious'];
  selectedTens = 0;
  constructor() { }

  ngOnInit() {
  }

  changeSelectedTens(i:number) {
    this.selectedTens = i;
  }

  selectTens(i:number) {
    this.selectedTens = i;
  }

}
