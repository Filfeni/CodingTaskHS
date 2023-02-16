export default class Entry {
    constructor() {
        this.id = 0;
        this.title = '';
        this.content = '';
        this.thumbnailUrl = '';
        this.creationDate = '';
    }
    id?: number;
    title: string;
    content: string;
    thumbnailUrl: string;
    creationDate: string;
}