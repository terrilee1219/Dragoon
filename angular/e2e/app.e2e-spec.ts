import { DragoonAppTemplatePage } from './app.po';

describe('DragoonApp App', function() {
  let page: DragoonAppTemplatePage;

  beforeEach(() => {
    page = new DragoonAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
