import { Component, OnInit } from '@angular/core';
import { detectIE10orLower } from './shared/utils/environmentUtils';
import { User } from './core/models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent  implements OnInit {
  title = '';
  isIE = false;
  currentUser: User;

  ngOnInit() {
    this.isIE = detectIE10orLower();
  }

  get versionInfo(): any {
    return null;
  }
}
