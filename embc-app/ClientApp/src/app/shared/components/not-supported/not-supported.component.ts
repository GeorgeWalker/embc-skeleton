import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-not-supported',
  templateUrl: './not-supported.component.html',
  styleUrls: ['./not-supported.component.scss']
})
export class NotSupportedComponent implements OnInit {
  show = false;

  constructor() { }

  ngOnInit() {
  }

}
