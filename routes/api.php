<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\UserController;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::middleware('auth:api')->get('/user', function (Request $request) {
    return $request->user();
});

Route::prefix('user')->group(function () {
    Route::get('getlist',[UserController::class,'getAllUser']);
    Route::post('create',[UserController::class,'createUser']);
    Route::post('update/{id}',[UserController::class,'updateUser']);
    Route::delete('delete/{id}',[UserController::class,'deleteUser']);
});

Route::prefix('category')->group(function () {
    Route::get('all', [App\Http\Controllers\CategoryController::class, 'getAllCategories']);
    Route::post('create', [\App\Http\Controllers\CategoryController::class, 'createCategories']);
    Route::post('update/{id}', [App\Http\Controllers\CategoryController::class, 'updateCategories']);
    Route::delete('delete/{id}', [App\Http\Controllers\CategoryController::class, 'deleteCategories']);
});


Route::prefix('product')->group(function () {
    Route::get('list', [\App\Http\Controllers\ProductController::class, 'getAllProducts']);
    Route::post('create', [\App\Http\Controllers\ProductController::class, 'createProducts']);
    Route::post('update/{id}', [\App\Http\Controllers\ProductController::class, 'updateProducts']);
    Route::delete('delete/{id}', [\App\Http\Controllers\ProductController::class, 'deleteProducts']);
});
