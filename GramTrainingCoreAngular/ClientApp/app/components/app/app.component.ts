import { Component } from '@angular/core';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    selectedTab = { tab: 'trains' };

    selectTab(tabName: string) {
        this.selectedTab.tab = tabName;
    }
}
