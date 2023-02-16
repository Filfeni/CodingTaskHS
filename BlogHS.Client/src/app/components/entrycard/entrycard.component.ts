import { Component, Input } from '@angular/core';
import Entry from 'src/app/models/Entry';

@Component({
  selector: 'app-entrycard',
  templateUrl: './entrycard.component.html',
  styleUrls: ['./entrycard.component.css']
})
export class EntrycardComponent {
  @Input() entry: Entry;

  constructor(){
    this.entry = new Entry();
  }
  ngOnInit(): void {}
}
