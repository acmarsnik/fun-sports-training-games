(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/app.component.html":
/*!************************************!*\
  !*** ./src/app/app.component.html ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!--The content below is only a placeholder and can be replaced.-->\r\n<div style=\"text-align:center\">\r\n  <h1>\r\n    Welcome to {{ title }}!\r\n  </h1>\r\n</div>\r\n<app-target-add></app-target-add>\r\n\r\n\r\n\r\n"

/***/ }),

/***/ "./src/app/app.component.scss":
/*!************************************!*\
  !*** ./src/app/app.component.scss ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};

var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.title = 'Fun Sports Training Games';
    }
    AppComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-root',
            template: __webpack_require__(/*! ./app.component.html */ "./src/app/app.component.html"),
            styles: [__webpack_require__(/*! ./app.component.scss */ "./src/app/app.component.scss")]
        })
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _baseball_pitching_target_add_target_add_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./baseball/pitching/target-add/target-add.component */ "./src/app/baseball/pitching/target-add/target-add.component.ts");
/* harmony import */ var _baseball_pitching_targets_view_targets_view_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./baseball/pitching/targets-view/targets-view.component */ "./src/app/baseball/pitching/targets-view/targets-view.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};







var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [
                _app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"],
                _baseball_pitching_target_add_target_add_component__WEBPACK_IMPORTED_MODULE_5__["TargetAddComponent"],
                _baseball_pitching_targets_view_targets_view_component__WEBPACK_IMPORTED_MODULE_6__["TargetsViewComponent"]
            ],
            imports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__["BrowserModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_2__["ReactiveFormsModule"],
                _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClientModule"],
            ],
            providers: [],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/baseball/pitching/target-add/target-add.component.html":
/*!************************************************************************!*\
  !*** ./src/app/baseball/pitching/target-add/target-add.component.html ***!
  \************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<form [formGroup]=\"inputForm\" (ngSubmit)=\"onSubmit()\">\r\n  <div class=\"row m -5\">\r\n    <div class=\"col-md-4\">\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n      <div class=\"form-row\">\r\n        <div class=\"form-group col-md-12\">\r\n          <input id=\"scoreInput\" type=\"number\" formControlName=\"scoreInput\" min=\"0\" max=\"10\">\r\n          <button type=\"submit\">Submit</button>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n    </div>\r\n  </div>\r\n</form>\r\n<div class=\"row m -5\">\r\n  <div class=\"col-md-4\">\r\n  </div>\r\n  <div class=\"col-md-4\">\r\n    <div class=\"row\">\r\n      <div class=\"col-md-12\">\r\n        <button (click)=\"showHide()\">{{showHideText}}</button>\r\n      </div>\r\n    </div>\r\n  </div>\r\n  <div class=\"col-md-4\">\r\n  </div>\r\n</div>\r\n<div class=\"row m -5\">\r\n  <div class=\"col-md-12\">\r\n    <app-targets-view [isVisible]=\"isVisible\" [targetScores]=\"targetScores\"></app-targets-view>\r\n  </div>\r\n</div>"

/***/ }),

/***/ "./src/app/baseball/pitching/target-add/target-add.component.scss":
/*!************************************************************************!*\
  !*** ./src/app/baseball/pitching/target-add/target-add.component.scss ***!
  \************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/baseball/pitching/target-add/target-add.component.ts":
/*!**********************************************************************!*\
  !*** ./src/app/baseball/pitching/target-add/target-add.component.ts ***!
  \**********************************************************************/
/*! exports provided: TargetAddComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TargetAddComponent", function() { return TargetAddComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _services_target_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../services/target.service */ "./src/app/services/target.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var TargetAddComponent = /** @class */ (function () {
    function TargetAddComponent(fb, targetService) {
        this.fb = fb;
        this.targetService = targetService;
        this.isVisible = false;
        this.showHideText = 'Show';
        this.targetScores = [];
        this.createForm();
        this.inputForm.setValue({ scoreInput: 0 });
    }
    TargetAddComponent.prototype.ngOnInit = function () {
        this.getTargetScores();
    };
    TargetAddComponent.prototype.createForm = function () {
        this.inputForm = this.fb.group({
            scoreInput: [0, [_angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].min(0), _angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].max(10)]]
        });
    };
    TargetAddComponent.prototype.onSubmit = function () {
        this.score = this.inputForm.value.scoreInput;
        this.targetService.addTarget(this.score).subscribe(function (it) {
            // this.targetScores = it;
        });
    };
    TargetAddComponent.prototype.showHide = function () {
        if (this.isVisible) {
            this.isVisible = false;
            this.showHideText = 'Show';
        }
        else {
            this.isVisible = true;
            this.showHideText = 'Hide';
        }
    };
    TargetAddComponent.prototype.getTargetScores = function () {
        var _this = this;
        this.targetService.getTargetScores()
            .subscribe(function (it) {
            _this.targetScores = it;
        });
    };
    TargetAddComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-target-add',
            template: __webpack_require__(/*! ./target-add.component.html */ "./src/app/baseball/pitching/target-add/target-add.component.html"),
            styles: [__webpack_require__(/*! ./target-add.component.scss */ "./src/app/baseball/pitching/target-add/target-add.component.scss")]
        }),
        __metadata("design:paramtypes", [_angular_forms__WEBPACK_IMPORTED_MODULE_1__["FormBuilder"], _services_target_service__WEBPACK_IMPORTED_MODULE_2__["TargetService"]])
    ], TargetAddComponent);
    return TargetAddComponent;
}());



/***/ }),

/***/ "./src/app/baseball/pitching/targets-view/targets-view.component.html":
/*!****************************************************************************!*\
  !*** ./src/app/baseball/pitching/targets-view/targets-view.component.html ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"isVisible\" class=\"mr-5 mt-5\">\r\n  <div class=\"table-responsive mx-5 mb-5\">\r\n      <table class=\"table table-striped table-hover\">\r\n          <!-- <caption>Target Scores</caption> -->\r\n          <tr>\r\n              <th scope=\"col\">Id</th>\r\n              <th scope=\"col\">Score</th>\r\n          </tr>\r\n          <ng-container *ngFor=\"let targetScore of targetScores\">\r\n              <tr>\r\n\r\n                  <td>{{targetScore.id}}</td>\r\n                  <td>{{targetScore.score}} </td>\r\n              </tr>\r\n          </ng-container>\r\n      </table>\r\n  </div>\r\n</div>\r\n"

/***/ }),

/***/ "./src/app/baseball/pitching/targets-view/targets-view.component.scss":
/*!****************************************************************************!*\
  !*** ./src/app/baseball/pitching/targets-view/targets-view.component.scss ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/baseball/pitching/targets-view/targets-view.component.ts":
/*!**************************************************************************!*\
  !*** ./src/app/baseball/pitching/targets-view/targets-view.component.ts ***!
  \**************************************************************************/
/*! exports provided: TargetsViewComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TargetsViewComponent", function() { return TargetsViewComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var TargetsViewComponent = /** @class */ (function () {
    function TargetsViewComponent() {
        this.targetScores = [];
    }
    TargetsViewComponent.prototype.ngOnInit = function () {
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Input"])(),
        __metadata("design:type", Array)
    ], TargetsViewComponent.prototype, "targetScores", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Input"])(),
        __metadata("design:type", Boolean)
    ], TargetsViewComponent.prototype, "isVisible", void 0);
    TargetsViewComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-targets-view',
            template: __webpack_require__(/*! ./targets-view.component.html */ "./src/app/baseball/pitching/targets-view/targets-view.component.html"),
            styles: [__webpack_require__(/*! ./targets-view.component.scss */ "./src/app/baseball/pitching/targets-view/targets-view.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], TargetsViewComponent);
    return TargetsViewComponent;
}());



/***/ }),

/***/ "./src/app/services/target.service.ts":
/*!********************************************!*\
  !*** ./src/app/services/target.service.ts ***!
  \********************************************/
/*! exports provided: TargetService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TargetService", function() { return TargetService; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _environments_environment_local__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../environments/environment.local */ "./src/environments/environment.local.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var options = { headers: new _angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpHeaders"]({ 'Content-Type': 'application/json' }) };
var TargetService = /** @class */ (function () {
    function TargetService(http) {
        this.http = http;
        this.target_scores = [0, 1];
        this.scoresUrl = _environments_environment_local__WEBPACK_IMPORTED_MODULE_2__["environment"].scoresUrl;
    }
    TargetService.prototype.addTarget = function (target_score) {
        console.log(target_score);
        console.log(this.scoresUrl);
        var data = { userId: 1, score: target_score };
        return this.http.put(this.scoresUrl, data, options)
            .pipe();
    };
    TargetService.prototype.deleteTarget = function (index) {
        this.target_scores.splice(index, 1);
    };
    TargetService.prototype.getTargets = function () {
        return this.target_scores;
    };
    /* getTargetScores(): Observable<{ id: number, score: number }[]> {
      const url = 'api/targetScores';
      return this.http.get<{ id: number, score: number }[]>(url)
      .pipe(
      );
    } */
    TargetService.prototype.getTargetScores = function () {
        return this.http.get(this.scoresUrl)
            .pipe();
    };
    TargetService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])({
            providedIn: 'root'
        }),
        __metadata("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClient"]])
    ], TargetService);
    return TargetService;
}());



/***/ }),

/***/ "./src/environments/environment.local.ts":
/*!***********************************************!*\
  !*** ./src/environments/environment.local.ts ***!
  \***********************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
var baseUrl = 'http://localhost:58247/api/';
var environment = {
    production: false,
    scoresUrl: baseUrl + 'Scores',
};


/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var baseUrl = 'https://fstg.azurewebsites.net/api/';
var environment = {
    production: false,
    scoresUrl: baseUrl + 'Scores',
};
/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.log(err); });


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\samples\fstg\fun-sports-training-games\WebUi\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map