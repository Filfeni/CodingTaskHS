import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';
import Entry from 'src/app/models/Entry';

@Component({
  selector: 'app-entrycard',
  templateUrl: './entrycard.component.html',
  styleUrls: ['./entrycard.component.css']
})
export class EntrycardComponent implements OnInit {
  @Input() entry!: Entry;
  @Output() deleteEmitter = new EventEmitter<number>(); 

  constructor(private router: Router){
  }

  ngOnInit(): void {}
  
  Update(){
    this.router.navigate([`/update/${this.entry.id}`]);
  }

  Delete(){
    this.deleteEmitter.emit(this.entry.id);
  }
  
  viewDetails(){
    this.router.navigate([`/detail/${this.entry.id}`]);
  }

  shortenContent(words: string): string {
    return `${words.slice(0, 130)} …`;
  }
}
