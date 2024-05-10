export class Section {
  id: string | null;
  titleSection: string | null;
  headlines = new Array<string>();

  constructor(id: string | null = null, titleSection: string | null = null) {
    this.id = id;
    this.titleSection = titleSection;
  }
}
