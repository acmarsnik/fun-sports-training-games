import { NavComponent } from './nav/nav.component';
import { TestBed, async } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { TargetAddComponent } from './baseball/pitching/target-add/target-add.component';
import { TargetsViewComponent } from './baseball/pitching/targets-view/targets-view.component';
import { EnvironmentComponent } from './environment/environment.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ScoresComponent } from './scores/scores.component';
describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        AppComponent,
        TargetAddComponent,
        TargetsViewComponent,
        EnvironmentComponent,
        NavComponent,
        DashboardComponent,
        ScoresComponent
      ]
    }).compileComponents();
  }));
  it('should create the app', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  }));
  it('should render an app-nav tag within a div', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('div > app-nav').textContent).toBeDefined();
  }));
  it('should render title in a span tag', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('span#appTitle').textContent).toContain('Welcome to Fun Sports Training Games!');
  }));
});
