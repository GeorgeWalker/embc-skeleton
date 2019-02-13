import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-side-box',
  templateUrl: './side-box.component.html',
  styleUrls: ['./side-box.component.scss']
})
export class SideBoxComponent implements OnInit {
  @Input() title: string = 'Sample Title';

  constructor() { }

  ngOnInit() {
  }

}
