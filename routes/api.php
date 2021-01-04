<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use \App\Http\Controllers\CategoryController;

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
    Route::get('getlist',[App\Http\Controllers\UserController::class,'getAllUser']);
    Route::post('create',[App\Http\Controllers\UserController::class,'createUser']);
    Route::post('update/{id}',[App\Http\Controllers\UserController::class,'updateUser']);
    Route::delete('delete/{id}',[App\Http\Controllers\UserController::class,'deleteUser']);
});

Route::prefix('categories')->group(function () {
    Route::get('all', [CategoryController::class, 'getAllCategory']);
    Route::post('create', [CategoryController::class, 'createCategory']);
    Route::post('update/{id}', [CategoryController::class, 'updateCategory']);
    Route::delete('delete/{id}', [CategoryController::class, 'deleteCategory']);
});


Route::prefix('product')->group(function () {
    Route::get('list', [\App\Http\Controllers\ProductController::class, 'getAllProducts']);
    Route::post('create', [\App\Http\Controllers\ProductController::class, 'createProducts']);
    Route::post('update/{id}', [\App\Http\Controllers\ProductController::class, 'updateProducts']);
    Route::delete('delete/{id}', [\App\Http\Controllers\ProductController::class, 'deleteProducts']);
});
