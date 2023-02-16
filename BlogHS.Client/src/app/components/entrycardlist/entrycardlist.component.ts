import { Component } from '@angular/core';
import Entry from 'src/app/models/Entry';

@Component({
  selector: 'app-entrycardlist',
  templateUrl: './entrycardlist.component.html',
  styleUrls: ['./entrycardlist.component.css']
})
export class EntrycardlistComponent {
  entries : Entry[];
  constructor(){
    this.entries = [{
      title: "What happened today at the park!",
      content: "Today I went to the park with my dog Ben and we met more dogs whose he played with until the afternoon.",
      thumbnailUrl:"https://www.aacounty.org/sebin/n/m/dogpark.jpg",
      creationDate: "2013-06-23"
    },{
      title: "What happened today at the park!",
      content: "Today I went to the park with my dog Ben and we met more dogs whose he played with until the afternoon.",
      thumbnailUrl:"https://www.aacounty.org/sebin/n/m/dogpark.jpg",
      creationDate: "2013-06-23"
    },{
      title: "What happened today at the park!",
      content: "Today I went to the park with my dog Ben and we met more dogs whose he played with until the afternoon.",
      thumbnailUrl:"https://www.aacounty.org/sebin/n/m/dogpark.jpg",
      creationDate: "2013-06-23"
    },{
      title: "What happened today at the park!",
      content: "Today I went to the park with my dog Ben and we met more dogs whose he played with until the afternoon.",
      thumbnailUrl:"https://www.aacounty.org/sebin/n/m/dogpark.jpg",
      creationDate: "2013-06-23"
    },{
      title: "What happened today at the park!",
      content: "Today I went to the park with my dog Ben and we met more dogs whose he played with until the afternoon.",
      thumbnailUrl:"https://www.aacounty.org/sebin/n/m/dogpark.jpg",
      creationDate: "2013-06-23"
    }] 
  }

  onInit(): void {}
}
