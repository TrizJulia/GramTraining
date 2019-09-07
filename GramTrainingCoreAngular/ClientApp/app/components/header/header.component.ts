import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  @Output() tabSelected = new EventEmitter<string>();
  @Input() selectedTab: {tabName: string};
  constructor() { }

  ngOnInit() {
  }

  Navigate(tabName: string) {
    this.tabSelected.emit(tabName);
    this.selectedTab.tabName = tabName;
  }

}
